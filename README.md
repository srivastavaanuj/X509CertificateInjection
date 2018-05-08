Sign an assembly using a X509 certificate.

Step 1:
Create a test X509 certificate: 
makecert.exe -r -pe -ss MY -sky exchange -n CN=TestCertAks CodeSign.cer   

Step 2:
Signing:Install SignTool.exe if not present. (E.g. Check at C:\Program Files (x86)\Windows Kits\10\bin\x86)
Command for signing the dll:
SignTool sign /n TestCertAKS C:\_D\VerifyCalersAuthenticode.dll 

Step3:
Fetch certificate from signed assembly:
Run the console ClientApp and pass the signed dll path as input. 


 

