# Unity Protobuf 模板
开箱即用

## 依赖库
### protobuf-net
[地址](https://github.com/DGHeroin/protobuf-net)

## 例子

```c#
UserInfo user = new UserInfo() {
    Id = 1,
    Name = "MyName",
    Address = new AddressInfo() {
        Street = "MyStreet",
        ZIP = 123456
    }
};
try {
    byte[] bytes = Proto.Encode<UserInfo>(user);
    UserInfo newUser = Proto.Decode<UserInfo>(bytes);
    Debug.Log(newUser);
} catch (Exception e) {
    Debug.Log(e);
}

```

```c#
[ProtoContract]
public class UserInfo {
    [ProtoMember(1)]
    public int Id;

    [ProtoMember(2)]
    public string Name;

    [ProtoMember(3)]
    public AddressInfo Address;
}

[ProtoContract]
public class AddressInfo {
    [ProtoMember(1)]
    public string Street;

    [ProtoMember(2)]
    public int ZIP;
}
```
