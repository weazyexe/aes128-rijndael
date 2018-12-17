# AES-128 / Rijndael
Rijndael 128 bit algorithm.

- Create AES object with cipher key as parameter
- Use AES.Encrypt static method to encrypt
- To decrypt use AES.Decrypt.

# Using
Create byte matrix - cipher key and initialize AES object.
```
byte[,] key = { { 0x2b, 0x28, 0xab, 0x09 }, { 0x7e, 0xae, 0xf7, 0xcf }, { 0x15, 0xd2, 0x15, 0x4f }, { 0x16, 0xa6, 0x88, 0x3c } };
AES aes = new AES(key);
```

Encrypt:
```
byte[] encryptedArray = AES.Encrypt(sourceString);
```

Decrypt example:
```
string decryptedString = AES.Decrypt(byteArr);
```
dev. via Microsoft Visual Studio 2017
