//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: InitCommand.proto
// Note: requires additional types generated from: ProductVersion.proto
// Note: requires additional types generated from: ClientInfo.proto
namespace Alachisoft.NCache.Common.Protobuf
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"InitCommand")]
  public partial class InitCommand : global::ProtoBuf.IExtensible
  {
    public InitCommand() {}
    

    private string _cacheId = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"cacheId", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string cacheId
    {
      get { return _cacheId; }
      set { _cacheId = value; }
    }

    private long _requestId = default(long);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"requestId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long requestId
    {
      get { return _requestId; }
      set { _requestId = value; }
    }

    private string _clientId = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"clientId", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string clientId
    {
      get { return _clientId; }
      set { _clientId = value; }
    }

    private string _userId = @"dummyUser";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"userId", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(@"dummyUser")]
    public string userId
    {
      get { return _userId; }
      set { _userId = value; }
    }

    private string _pwd = @"dummypassword";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"pwd", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(@"dummypassword")]
    public string pwd
    {
      get { return _pwd; }
      set { _pwd = value; }
    }

    private string _licenceCode = "";
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"licenceCode", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string licenceCode
    {
      get { return _licenceCode; }
      set { _licenceCode = value; }
    }

    private string _licenceInfo = "";
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"licenceInfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string licenceInfo
    {
      get { return _licenceInfo; }
      set { _licenceInfo = value; }
    }

    private bool _isDotnetClient = default(bool);
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"isDotnetClient", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool isDotnetClient
    {
      get { return _isDotnetClient; }
      set { _isDotnetClient = value; }
    }

  

    private byte[] _binaryUserid = null;
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"binaryUserid", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] binaryUserid
    {
      get { return _binaryUserid; }
      set { _binaryUserid = value; }
    }

    private byte[] _binaryPwd = null;
    [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"binaryPwd", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] binaryPwd
    {
      get { return _binaryPwd; }
      set { _binaryPwd = value; }
    }

    private string _clientEditionId = "";
    [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"clientEditionId", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string clientEditionId
    {
      get { return _clientEditionId; }
      set { _clientEditionId = value; }
    }

    private int _clientVersion = default(int);
    [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"clientVersion", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int clientVersion
    {
      get { return _clientVersion; }
      set { _clientVersion = value; }
    }

    private string _clientIP = "";
    [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"clientIP", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string clientIP
    {
      get { return _clientIP; }
      set { _clientIP = value; }
    }

    private bool _isAzureClient = default(bool);
    [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"isAzureClient", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool isAzureClient
    {
      get { return _isAzureClient; }
      set { _isAzureClient = value; }
    }

    private Alachisoft.NCache.Common.Protobuf.ProductVersion _productVersion = null;
    [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"productVersion", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Alachisoft.NCache.Common.Protobuf.ProductVersion productVersion
    {
      get { return _productVersion; }
      set { _productVersion = value; }
    }

    private Alachisoft.NCache.Common.Protobuf.ClientInfo _clientInfo = null;
    [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"clientInfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Alachisoft.NCache.Common.Protobuf.ClientInfo clientInfo
    {
      get { return _clientInfo; }
      set { _clientInfo = value; }
    }

    private bool _secureConnectionEnabled = (bool)false;
    [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"secureConnectionEnabled", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue((bool)false)]
    public bool secureConnectionEnabled
    {
      get { return _secureConnectionEnabled; }
      set { _secureConnectionEnabled = value; }
    }

    private int _operationTimeout = (int)-1;
    [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"operationTimeout", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int operationTimeout
    {
      get { return _operationTimeout; }
      set { _operationTimeout = value; }
    }

    private string _macAddress = "";
    [global::ProtoBuf.ProtoMember(20, IsRequired = false, Name=@"macAddress", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string macAddress
    {
      get { return _macAddress; }
      set { _macAddress = value; }
    }

    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}