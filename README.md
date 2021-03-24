
# Projeto de teste com uma lib para auxiliar o uso do Selenium.

Existem dois testes para verificação da ação Logar no site Duolingo, são eles:

 - LoginComUsuarioSenha_CredenciaisCorretas_Sucesso
 - LoginComUsuarioSenha_CredenciaisErradas_Erro
'*' Para funcionamento é necessário adicionar credenciais válidas.

#### É possível executar com diferentes web drivers:
* Chrome/HeadlessChrome
* Firefox/HeadlessFirefox
* RemoteWebDriverChrome (uso da lib Infra.Docker). Utilizando essa opção, um container docker é executado no início do teste e excluído ao final. Utilizado Docker for Windows com WSL2.