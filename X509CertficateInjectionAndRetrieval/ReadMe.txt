1)Create a X.509 certificate

Command to create test certificate:
makecert.exe -r -pe -ss MY -sky exchange -n CN=MyPrivateCert CodeSign.cer 

2)Sign a dll using this certificate

(SignTool installation path)
CD C:\Program Files (x86)\Windows Kits\10\bin\x64

Command to create sign dll using certificate:
SignTool sign /n MyPrivateCertAKS C:\_D\VerifyCalersAuthenticode.dll 

3)Run the Application and pass the signed dll path as input. Application will fetch the certificate from dll.

4)Run the Application and pass the unsigned dll path as input.Application will verify the dll and give failure result.

