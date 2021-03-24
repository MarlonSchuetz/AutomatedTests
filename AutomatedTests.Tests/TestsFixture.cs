using Infra.Docker;
using System;
using System.Threading;

namespace AutomatedTests.Tests
{
    public class TestsFixture : IDisposable
    {
        private DockerService _dockerService;
        private RunResult _runResult;

        public TestsFixture() 
        {
            // docker run -d -p 4444:4444 -v /dev/shm:/dev/shm selenium/standalone-chrome:4.0.0-beta-3-prerelease-20210319
            // https://github.com/SeleniumHQ/docker-selenium
            var runParameters = new RunParameters("selenium/standalone-chrome", "4.0.0-beta-3-prerelease-20210319")
            {
                HostPort = "4444",
                ExposedPort = "4444",
                Volume = "/dev/shm:/dev/shm"
            };

            _dockerService = new DockerService();
            _runResult = _dockerService.RunContainer(runParameters);

            // Time to up the container.
            Thread.Sleep(5000);

            if (!_runResult.Success)
            {
                throw new Exception("Error to up the container.");
            }
        }

        public void Dispose()
        {
            _dockerService.StopContainer(_runResult.ContainerName);
            _dockerService.RemoveContainer(_runResult.ContainerName);
            _dockerService.RemoveImage(_runResult.ImageName, _runResult.ImageTag);
        }
    }
}
