# Csharp Protobuf

## Simple Protobuf - LoginPacket

| name | type |
|---|---|
| Code | uint32
| Size | uint32
| SizeOfUsername | uint32
| Username | string
| SizeOfPassword | uint32
| Password | string

## How to compile protobuf

```sh
protoc --csharp_out=. protos/*
```

## How to install protobuf package from NuGet

```sh
dotnet add package Google.Protobuf --version 3.9.1
```
