SharpFtpServer
==============

FTP Server in C# - with IPv6 Support.

Used original code to find out forgotten encrypted passwords within WSFTP.

----

How to create self-certifcate, server.cer:

1. Open Developer Command Prompt
1. makecert -r -pe -n "CN=localhost" -ss my -sr localmachine -sky    exchange -sp "Microsoft RSA SChannel Cryptographic Provider" -sy 12 server.cer
