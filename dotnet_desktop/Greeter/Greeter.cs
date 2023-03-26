// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Greeter/protos/greeter.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Com.Example.Grpc {

  /// <summary>Holder for reflection information generated from Greeter/protos/greeter.proto</summary>
  public static partial class GreeterReflection {

    #region Descriptor
    /// <summary>File descriptor for Greeter/protos/greeter.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GreeterReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxHcmVldGVyL3Byb3Rvcy9ncmVldGVyLnByb3RvEhBjb20uZXhhbXBsZS5n",
            "cnBjIuQBCgxIZWxsb1JlcXVlc3QSDAoEbmFtZRgBIAEoCRILCgNhZ2UYAiAB",
            "KAUSDwoHaG9iYmllcxgDIAMoCRJECgtiYWdPZlRyaWNrcxgEIAMoCzIvLmNv",
            "bS5leGFtcGxlLmdycGMuSGVsbG9SZXF1ZXN0LkJhZ09mVHJpY2tzRW50cnkS",
            "LgoJc2VudGltZW50GAUgASgOMhsuY29tLmV4YW1wbGUuZ3JwYy5TZW50aW1l",
            "bnQaMgoQQmFnT2ZUcmlja3NFbnRyeRILCgNrZXkYASABKAkSDQoFdmFsdWUY",
            "AiABKAk6AjgBIiEKDUhlbGxvUmVzcG9uc2USEAoIZ3JlZXRpbmcYASABKAkq",
            "LQoJU2VudGltZW50EgkKBUhBUFBZEAASCgoGU0xFRVBZEAESCQoFQU5HUlkQ",
            "AjKqAQoPR3JlZXRpbmdTZXJ2aWNlEksKCGdyZWV0aW5nEh4uY29tLmV4YW1w",
            "bGUuZ3JwYy5IZWxsb1JlcXVlc3QaHy5jb20uZXhhbXBsZS5ncnBjLkhlbGxv",
            "UmVzcG9uc2USSgoHZ29vZGJ5ZRIeLmNvbS5leGFtcGxlLmdycGMuSGVsbG9S",
            "ZXF1ZXN0Gh8uY29tLmV4YW1wbGUuZ3JwYy5IZWxsb1Jlc3BvbnNlQjYKG2lv",
            "LmdycGMuZXhhbXBsZXMuaGVsbG93b3JsZEIPSGVsbG9Xb3JsZFByb3RvUAGi",
            "AgNITFdiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Com.Example.Grpc.Sentiment), }, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Com.Example.Grpc.HelloRequest), global::Com.Example.Grpc.HelloRequest.Parser, new[]{ "Name", "Age", "Hobbies", "BagOfTricks", "Sentiment" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, }),
            new pbr::GeneratedClrTypeInfo(typeof(global::Com.Example.Grpc.HelloResponse), global::Com.Example.Grpc.HelloResponse.Parser, new[]{ "Greeting" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  public enum Sentiment {
    [pbr::OriginalName("HAPPY")] Happy = 0,
    [pbr::OriginalName("SLEEPY")] Sleepy = 1,
    [pbr::OriginalName("ANGRY")] Angry = 2,
  }

  #endregion

  #region Messages
  public sealed partial class HelloRequest : pb::IMessage<HelloRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<HelloRequest> _parser = new pb::MessageParser<HelloRequest>(() => new HelloRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<HelloRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Com.Example.Grpc.GreeterReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HelloRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HelloRequest(HelloRequest other) : this() {
      name_ = other.name_;
      age_ = other.age_;
      hobbies_ = other.hobbies_.Clone();
      bagOfTricks_ = other.bagOfTricks_.Clone();
      sentiment_ = other.sentiment_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HelloRequest Clone() {
      return new HelloRequest(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "age" field.</summary>
    public const int AgeFieldNumber = 2;
    private int age_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Age {
      get { return age_; }
      set {
        age_ = value;
      }
    }

    /// <summary>Field number for the "hobbies" field.</summary>
    public const int HobbiesFieldNumber = 3;
    private static readonly pb::FieldCodec<string> _repeated_hobbies_codec
        = pb::FieldCodec.ForString(26);
    private readonly pbc::RepeatedField<string> hobbies_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<string> Hobbies {
      get { return hobbies_; }
    }

    /// <summary>Field number for the "bagOfTricks" field.</summary>
    public const int BagOfTricksFieldNumber = 4;
    private static readonly pbc::MapField<string, string>.Codec _map_bagOfTricks_codec
        = new pbc::MapField<string, string>.Codec(pb::FieldCodec.ForString(10, ""), pb::FieldCodec.ForString(18, ""), 34);
    private readonly pbc::MapField<string, string> bagOfTricks_ = new pbc::MapField<string, string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<string, string> BagOfTricks {
      get { return bagOfTricks_; }
    }

    /// <summary>Field number for the "sentiment" field.</summary>
    public const int SentimentFieldNumber = 5;
    private global::Com.Example.Grpc.Sentiment sentiment_ = global::Com.Example.Grpc.Sentiment.Happy;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Com.Example.Grpc.Sentiment Sentiment {
      get { return sentiment_; }
      set {
        sentiment_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as HelloRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(HelloRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (Age != other.Age) return false;
      if(!hobbies_.Equals(other.hobbies_)) return false;
      if (!BagOfTricks.Equals(other.BagOfTricks)) return false;
      if (Sentiment != other.Sentiment) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Age != 0) hash ^= Age.GetHashCode();
      hash ^= hobbies_.GetHashCode();
      hash ^= BagOfTricks.GetHashCode();
      if (Sentiment != global::Com.Example.Grpc.Sentiment.Happy) hash ^= Sentiment.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (Age != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Age);
      }
      hobbies_.WriteTo(output, _repeated_hobbies_codec);
      bagOfTricks_.WriteTo(output, _map_bagOfTricks_codec);
      if (Sentiment != global::Com.Example.Grpc.Sentiment.Happy) {
        output.WriteRawTag(40);
        output.WriteEnum((int) Sentiment);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (Age != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Age);
      }
      hobbies_.WriteTo(ref output, _repeated_hobbies_codec);
      bagOfTricks_.WriteTo(ref output, _map_bagOfTricks_codec);
      if (Sentiment != global::Com.Example.Grpc.Sentiment.Happy) {
        output.WriteRawTag(40);
        output.WriteEnum((int) Sentiment);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Age != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Age);
      }
      size += hobbies_.CalculateSize(_repeated_hobbies_codec);
      size += bagOfTricks_.CalculateSize(_map_bagOfTricks_codec);
      if (Sentiment != global::Com.Example.Grpc.Sentiment.Happy) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Sentiment);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(HelloRequest other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Age != 0) {
        Age = other.Age;
      }
      hobbies_.Add(other.hobbies_);
      bagOfTricks_.Add(other.bagOfTricks_);
      if (other.Sentiment != global::Com.Example.Grpc.Sentiment.Happy) {
        Sentiment = other.Sentiment;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 16: {
            Age = input.ReadInt32();
            break;
          }
          case 26: {
            hobbies_.AddEntriesFrom(input, _repeated_hobbies_codec);
            break;
          }
          case 34: {
            bagOfTricks_.AddEntriesFrom(input, _map_bagOfTricks_codec);
            break;
          }
          case 40: {
            Sentiment = (global::Com.Example.Grpc.Sentiment) input.ReadEnum();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 16: {
            Age = input.ReadInt32();
            break;
          }
          case 26: {
            hobbies_.AddEntriesFrom(ref input, _repeated_hobbies_codec);
            break;
          }
          case 34: {
            bagOfTricks_.AddEntriesFrom(ref input, _map_bagOfTricks_codec);
            break;
          }
          case 40: {
            Sentiment = (global::Com.Example.Grpc.Sentiment) input.ReadEnum();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class HelloResponse : pb::IMessage<HelloResponse>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<HelloResponse> _parser = new pb::MessageParser<HelloResponse>(() => new HelloResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<HelloResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Com.Example.Grpc.GreeterReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HelloResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HelloResponse(HelloResponse other) : this() {
      greeting_ = other.greeting_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HelloResponse Clone() {
      return new HelloResponse(this);
    }

    /// <summary>Field number for the "greeting" field.</summary>
    public const int GreetingFieldNumber = 1;
    private string greeting_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Greeting {
      get { return greeting_; }
      set {
        greeting_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as HelloResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(HelloResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Greeting != other.Greeting) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Greeting.Length != 0) hash ^= Greeting.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Greeting.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Greeting);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Greeting.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Greeting);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Greeting.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Greeting);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(HelloResponse other) {
      if (other == null) {
        return;
      }
      if (other.Greeting.Length != 0) {
        Greeting = other.Greeting;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Greeting = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            Greeting = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
