Signing and retrieving a X509 certificate from an assembly

Creating a test X509 certificate: 
makecert.exe -r -pe -ss MY -sky exchange -n CN=TestCertAks CodeSign.cer 
Signing:
Install SignTool.exe if not present. (E.g. Check at C:\Program Files (x86)\Windows Kits\10\bin\x86)
Command for signing the dll:
SignTool sign /n TestCertAKS C:\_D\VerifyCalersAuthenticode.dll 

Fetch certificate from signed assembly:
Run the console ClientApp and pass the signed dll path as input. 
 

Import certificate:
Provide the certificate file path. (Certificate path can be injected to sensitive constant file.)
 

