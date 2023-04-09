﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataComm
{


    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "MessageModel", Namespace = "http://schemas.datacontract.org/2004/07/DataComm")]
    public partial class MessageModel : object, System.Runtime.Serialization.IExtensibleDataObject
    {

        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        private string AddressField;

        private string Date_TakenField;

        private int DeletedField;

        private int DeliveredField;

        private string EmailField;

        private string Message_TextField;

        private string NameField;

        private string PhoneField;

        private int ReadField;

        private string RecipientField;

        private string Sent_FromField;

        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Address
        {
            get
            {
                return this.AddressField;
            }
            set
            {
                this.AddressField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Date_Taken
        {
            get
            {
                return this.Date_TakenField;
            }
            set
            {
                this.Date_TakenField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Deleted
        {
            get
            {
                return this.DeletedField;
            }
            set
            {
                this.DeletedField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Delivered
        {
            get
            {
                return this.DeliveredField;
            }
            set
            {
                this.DeliveredField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email
        {
            get
            {
                return this.EmailField;
            }
            set
            {
                this.EmailField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Message_Text
        {
            get
            {
                return this.Message_TextField;
            }
            set
            {
                this.Message_TextField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Phone
        {
            get
            {
                return this.PhoneField;
            }
            set
            {
                this.PhoneField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Read
        {
            get
            {
                return this.ReadField;
            }
            set
            {
                this.ReadField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Recipient
        {
            get
            {
                return this.RecipientField;
            }
            set
            {
                this.RecipientField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Sent_From
        {
            get
            {
                return this.Sent_FromField;
            }
            set
            {
                this.Sent_FromField = value;
            }
        }
    }
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(ConfigurationName = "IMessageService", CallbackContract = typeof(IMessageServiceCallback))]
public interface IMessageService
{

    [System.ServiceModel.OperationContractAttribute(IsOneWay = true, Action = "http://tempuri.org/IMessageService/DeleteMessage")]
    void DeleteMessage(int mid);

    [System.ServiceModel.OperationContractAttribute(IsOneWay = true, Action = "http://tempuri.org/IMessageService/DeleteMessage")]
    System.Threading.Tasks.Task DeleteMessageAsync(int mid);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IMessageService/GetAllMessages", ReplyAction = "http://tempuri.org/IMessageService/GetAllMessagesResponse")]
    DataComm.MessageModel[] GetAllMessages(string id);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IMessageService/GetAllMessages", ReplyAction = "http://tempuri.org/IMessageService/GetAllMessagesResponse")]
    System.Threading.Tasks.Task<DataComm.MessageModel[]> GetAllMessagesAsync(string id);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IMessageService/GetDeletedMessages", ReplyAction = "http://tempuri.org/IMessageService/GetDeletedMessagesResponse")]
    DataComm.MessageModel[] GetDeletedMessages(string id);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IMessageService/GetDeletedMessages", ReplyAction = "http://tempuri.org/IMessageService/GetDeletedMessagesResponse")]
    System.Threading.Tasks.Task<DataComm.MessageModel[]> GetDeletedMessagesAsync(string id);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IMessageService/GetNewMessages", ReplyAction = "http://tempuri.org/IMessageService/GetNewMessagesResponse")]
    DataComm.MessageModel[] GetNewMessages(string id);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IMessageService/GetNewMessages", ReplyAction = "http://tempuri.org/IMessageService/GetNewMessagesResponse")]
    System.Threading.Tasks.Task<DataComm.MessageModel[]> GetNewMessagesAsync(string id);

    [System.ServiceModel.OperationContractAttribute(IsOneWay = true, Action = "http://tempuri.org/IMessageService/Join")]
    void Join(string userId);

    [System.ServiceModel.OperationContractAttribute(IsOneWay = true, Action = "http://tempuri.org/IMessageService/Join")]
    System.Threading.Tasks.Task JoinAsync(string userId);

    [System.ServiceModel.OperationContractAttribute(IsOneWay = true, Action = "http://tempuri.org/IMessageService/Leave")]
    void Leave(string userId);

    [System.ServiceModel.OperationContractAttribute(IsOneWay = true, Action = "http://tempuri.org/IMessageService/Leave")]
    System.Threading.Tasks.Task LeaveAsync(string userId);

    [System.ServiceModel.OperationContractAttribute(IsOneWay = true, Action = "http://tempuri.org/IMessageService/MarkDelivered")]
    void MarkDelivered(int mid);

    [System.ServiceModel.OperationContractAttribute(IsOneWay = true, Action = "http://tempuri.org/IMessageService/MarkDelivered")]
    System.Threading.Tasks.Task MarkDeliveredAsync(int mid);

    [System.ServiceModel.OperationContractAttribute(IsOneWay = true, Action = "http://tempuri.org/IMessageService/MarkNotDelivered")]
    void MarkNotDelivered(int mid);

    [System.ServiceModel.OperationContractAttribute(IsOneWay = true, Action = "http://tempuri.org/IMessageService/MarkNotDelivered")]
    System.Threading.Tasks.Task MarkNotDeliveredAsync(int mid);

    [System.ServiceModel.OperationContractAttribute(IsOneWay = true, Action = "http://tempuri.org/IMessageService/MarkNotRead")]
    void MarkNotRead(int mid);

    [System.ServiceModel.OperationContractAttribute(IsOneWay = true, Action = "http://tempuri.org/IMessageService/MarkNotRead")]
    System.Threading.Tasks.Task MarkNotReadAsync(int mid);

    [System.ServiceModel.OperationContractAttribute(IsOneWay = true, Action = "http://tempuri.org/IMessageService/MarkRead")]
    void MarkRead(int mid);

    [System.ServiceModel.OperationContractAttribute(IsOneWay = true, Action = "http://tempuri.org/IMessageService/MarkRead")]
    System.Threading.Tasks.Task MarkReadAsync(int mid);

    [System.ServiceModel.OperationContractAttribute(IsOneWay = true, Action = "http://tempuri.org/IMessageService/RestoreMessage")]
    void RestoreMessage(int mid);

    [System.ServiceModel.OperationContractAttribute(IsOneWay = true, Action = "http://tempuri.org/IMessageService/RestoreMessage")]
    System.Threading.Tasks.Task RestoreMessageAsync(int mid);

    [System.ServiceModel.OperationContractAttribute(IsOneWay = true, Action = "http://tempuri.org/IMessageService/SendMessage")]
    void SendMessage(DataComm.MessageModel message);

    [System.ServiceModel.OperationContractAttribute(IsOneWay = true, Action = "http://tempuri.org/IMessageService/SendMessage")]
    System.Threading.Tasks.Task SendMessageAsync(DataComm.MessageModel message);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface IMessageServiceCallback
{

    [System.ServiceModel.OperationContractAttribute(IsOneWay = true, Action = "http://tempuri.org/IMessageService/RecieveMessage")]
    void RecieveMessage(DataComm.MessageModel message);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface IMessageServiceChannel : IMessageService, System.ServiceModel.IClientChannel
{
}
