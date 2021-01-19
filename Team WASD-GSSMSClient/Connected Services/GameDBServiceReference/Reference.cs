﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Team_WASD_GSSMSClient.GameDBServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Game", Namespace="http://schemas.datacontract.org/2004/07/Team_WASD___Game_Store_Stock_Management_S" +
        "ystem")]
    [System.SerializableAttribute()]
    public partial class Game : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GameTitleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GenreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> InStockAmountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PlatformField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<double> PriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PublisherField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> ReleaseDateField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string GameTitle {
            get {
                return this.GameTitleField;
            }
            set {
                if ((object.ReferenceEquals(this.GameTitleField, value) != true)) {
                    this.GameTitleField = value;
                    this.RaisePropertyChanged("GameTitle");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Genre {
            get {
                return this.GenreField;
            }
            set {
                if ((object.ReferenceEquals(this.GenreField, value) != true)) {
                    this.GenreField = value;
                    this.RaisePropertyChanged("Genre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> InStockAmount {
            get {
                return this.InStockAmountField;
            }
            set {
                if ((this.InStockAmountField.Equals(value) != true)) {
                    this.InStockAmountField = value;
                    this.RaisePropertyChanged("InStockAmount");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Platform {
            get {
                return this.PlatformField;
            }
            set {
                if ((object.ReferenceEquals(this.PlatformField, value) != true)) {
                    this.PlatformField = value;
                    this.RaisePropertyChanged("Platform");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<double> Price {
            get {
                return this.PriceField;
            }
            set {
                if ((this.PriceField.Equals(value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Publisher {
            get {
                return this.PublisherField;
            }
            set {
                if ((object.ReferenceEquals(this.PublisherField, value) != true)) {
                    this.PublisherField = value;
                    this.RaisePropertyChanged("Publisher");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> ReleaseDate {
            get {
                return this.ReleaseDateField;
            }
            set {
                if ((this.ReleaseDateField.Equals(value) != true)) {
                    this.ReleaseDateField = value;
                    this.RaisePropertyChanged("ReleaseDate");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="GameDBServiceReference.IGameDBService")]
    public interface IGameDBService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameDBService/GetAllGames", ReplyAction="http://tempuri.org/IGameDBService/GetAllGamesResponse")]
        Team_WASD_GSSMSClient.GameDBServiceReference.Game[] GetAllGames();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameDBService/GetAllGames", ReplyAction="http://tempuri.org/IGameDBService/GetAllGamesResponse")]
        System.Threading.Tasks.Task<Team_WASD_GSSMSClient.GameDBServiceReference.Game[]> GetAllGamesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameDBService/FindAGame", ReplyAction="http://tempuri.org/IGameDBService/FindAGameResponse")]
        Team_WASD_GSSMSClient.GameDBServiceReference.Game FindAGame(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameDBService/FindAGame", ReplyAction="http://tempuri.org/IGameDBService/FindAGameResponse")]
        System.Threading.Tasks.Task<Team_WASD_GSSMSClient.GameDBServiceReference.Game> FindAGameAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameDBService/AddGame", ReplyAction="http://tempuri.org/IGameDBService/AddGameResponse")]
        void AddGame(Team_WASD_GSSMSClient.GameDBServiceReference.Game game);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameDBService/AddGame", ReplyAction="http://tempuri.org/IGameDBService/AddGameResponse")]
        System.Threading.Tasks.Task AddGameAsync(Team_WASD_GSSMSClient.GameDBServiceReference.Game game);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameDBService/EditGame", ReplyAction="http://tempuri.org/IGameDBService/EditGameResponse")]
        void EditGame(Team_WASD_GSSMSClient.GameDBServiceReference.Game game);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameDBService/EditGame", ReplyAction="http://tempuri.org/IGameDBService/EditGameResponse")]
        System.Threading.Tasks.Task EditGameAsync(Team_WASD_GSSMSClient.GameDBServiceReference.Game game);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameDBService/DeleteGame", ReplyAction="http://tempuri.org/IGameDBService/DeleteGameResponse")]
        void DeleteGame(Team_WASD_GSSMSClient.GameDBServiceReference.Game game);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameDBService/DeleteGame", ReplyAction="http://tempuri.org/IGameDBService/DeleteGameResponse")]
        System.Threading.Tasks.Task DeleteGameAsync(Team_WASD_GSSMSClient.GameDBServiceReference.Game game);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameDBService/GetAllPlatformGames", ReplyAction="http://tempuri.org/IGameDBService/GetAllPlatformGamesResponse")]
        Team_WASD_GSSMSClient.GameDBServiceReference.Game[] GetAllPlatformGames(string platformName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameDBService/GetAllPlatformGames", ReplyAction="http://tempuri.org/IGameDBService/GetAllPlatformGamesResponse")]
        System.Threading.Tasks.Task<Team_WASD_GSSMSClient.GameDBServiceReference.Game[]> GetAllPlatformGamesAsync(string platformName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameDBService/FindAGameByGameTitle", ReplyAction="http://tempuri.org/IGameDBService/FindAGameByGameTitleResponse")]
        Team_WASD_GSSMSClient.GameDBServiceReference.Game FindAGameByGameTitle(string gameTitle);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameDBService/FindAGameByGameTitle", ReplyAction="http://tempuri.org/IGameDBService/FindAGameByGameTitleResponse")]
        System.Threading.Tasks.Task<Team_WASD_GSSMSClient.GameDBServiceReference.Game> FindAGameByGameTitleAsync(string gameTitle);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IGameDBServiceChannel : Team_WASD_GSSMSClient.GameDBServiceReference.IGameDBService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GameDBServiceClient : System.ServiceModel.ClientBase<Team_WASD_GSSMSClient.GameDBServiceReference.IGameDBService>, Team_WASD_GSSMSClient.GameDBServiceReference.IGameDBService {
        
        public GameDBServiceClient() {
        }
        
        public GameDBServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public GameDBServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GameDBServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GameDBServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Team_WASD_GSSMSClient.GameDBServiceReference.Game[] GetAllGames() {
            return base.Channel.GetAllGames();
        }
        
        public System.Threading.Tasks.Task<Team_WASD_GSSMSClient.GameDBServiceReference.Game[]> GetAllGamesAsync() {
            return base.Channel.GetAllGamesAsync();
        }
        
        public Team_WASD_GSSMSClient.GameDBServiceReference.Game FindAGame(int id) {
            return base.Channel.FindAGame(id);
        }
        
        public System.Threading.Tasks.Task<Team_WASD_GSSMSClient.GameDBServiceReference.Game> FindAGameAsync(int id) {
            return base.Channel.FindAGameAsync(id);
        }
        
        public void AddGame(Team_WASD_GSSMSClient.GameDBServiceReference.Game game) {
            base.Channel.AddGame(game);
        }
        
        public System.Threading.Tasks.Task AddGameAsync(Team_WASD_GSSMSClient.GameDBServiceReference.Game game) {
            return base.Channel.AddGameAsync(game);
        }
        
        public void EditGame(Team_WASD_GSSMSClient.GameDBServiceReference.Game game) {
            base.Channel.EditGame(game);
        }
        
        public System.Threading.Tasks.Task EditGameAsync(Team_WASD_GSSMSClient.GameDBServiceReference.Game game) {
            return base.Channel.EditGameAsync(game);
        }
        
        public void DeleteGame(Team_WASD_GSSMSClient.GameDBServiceReference.Game game) {
            base.Channel.DeleteGame(game);
        }
        
        public System.Threading.Tasks.Task DeleteGameAsync(Team_WASD_GSSMSClient.GameDBServiceReference.Game game) {
            return base.Channel.DeleteGameAsync(game);
        }
        
        public Team_WASD_GSSMSClient.GameDBServiceReference.Game[] GetAllPlatformGames(string platformName) {
            return base.Channel.GetAllPlatformGames(platformName);
        }
        
        public System.Threading.Tasks.Task<Team_WASD_GSSMSClient.GameDBServiceReference.Game[]> GetAllPlatformGamesAsync(string platformName) {
            return base.Channel.GetAllPlatformGamesAsync(platformName);
        }
        
        public Team_WASD_GSSMSClient.GameDBServiceReference.Game FindAGameByGameTitle(string gameTitle) {
            return base.Channel.FindAGameByGameTitle(gameTitle);
        }
        
        public System.Threading.Tasks.Task<Team_WASD_GSSMSClient.GameDBServiceReference.Game> FindAGameByGameTitleAsync(string gameTitle) {
            return base.Channel.FindAGameByGameTitleAsync(gameTitle);
        }
    }
}