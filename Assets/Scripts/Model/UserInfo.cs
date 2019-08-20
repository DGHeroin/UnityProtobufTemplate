using System;
using ProtoBuf;

[ProtoContract]
public class UserInfo {
    [ProtoMember(1)]
    public int Id;

    [ProtoMember(2)]
    public string Name;

    [ProtoMember(3)]
    public AddressInfo Address;

    public override string ToString() {
        return string.Format("id:{0}\nname:{1}\naddress:{2} ", Id, Name, Address);
    }
}

[ProtoContract]
public class AddressInfo {
    [ProtoMember(1)]
    public string Street;

    [ProtoMember(2)]
    public int ZIP;

    public override string ToString() {
        return string.Format("street:{0}\nzip: {1}", Street, ZIP);
    }
}
