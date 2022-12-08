using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.Service
{
    public class ContractLineVocabulary : SimpleVocabulary
    {
        public ContractLineVocabulary()
        {
            VocabularyName = "Contract Line";
            KeyPrefix = "commonDataModel.contractline.service";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.ContractLine;

            AddGroup("ContractLine Details for Service", group =>
            {
			    ContractDetailId = group.Add(new VocabularyKey(nameof(ContractDetailId), "Contract Line", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Title = group.Add(new VocabularyKey(nameof(Title), "Title", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ActiveOn = group.Add(new VocabularyKey(nameof(ActiveOn), "Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AllotmentsOverage = group.Add(new VocabularyKey(nameof(AllotmentsOverage), "Allotments Overage", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    AllotmentsRemaining = group.Add(new VocabularyKey(nameof(AllotmentsRemaining), "Allotments Remaining", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    AllotmentsUsed = group.Add(new VocabularyKey(nameof(AllotmentsUsed), "Allotments Used", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ContractStateCode = group.Add(new VocabularyKey(nameof(ContractStateCode), "Contract State", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Discount = group.Add(new VocabularyKey(nameof(Discount), "Discount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    DiscountBase = group.Add(new VocabularyKey(nameof(DiscountBase), "Discount (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DiscountPercentage = group.Add(new VocabularyKey(nameof(DiscountPercentage), "Discount (%)", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    EffectivityCalendar = group.Add(new VocabularyKey(nameof(EffectivityCalendar), "Support Calendar", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExpiresOn = group.Add(new VocabularyKey(nameof(ExpiresOn), "End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    InitialQuantity = group.Add(new VocabularyKey(nameof(InitialQuantity), "Quantity", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    LineItemOrder = group.Add(new VocabularyKey(nameof(LineItemOrder), "Line Item Order", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    Net = group.Add(new VocabularyKey(nameof(Net), "Net", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    NetBase = group.Add(new VocabularyKey(nameof(NetBase), "Net (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Price = group.Add(new VocabularyKey(nameof(Price), "Total Price", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    PriceBase = group.Add(new VocabularyKey(nameof(PriceBase), "Total Price (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ProductSerialNumber = group.Add(new VocabularyKey(nameof(ProductSerialNumber), "Serial Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Rate = group.Add(new VocabularyKey(nameof(Rate), "Rate", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    RateBase = group.Add(new VocabularyKey(nameof(RateBase), "Rate (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ServiceContractUnitsCode = group.Add(new VocabularyKey(nameof(ServiceContractUnitsCode), "Service Contract Units", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TotalAllotments = group.Add(new VocabularyKey(nameof(TotalAllotments), "Total Allotments", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    AccountId = group.Add(new VocabularyKey(nameof(AccountId), "Account", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ContactId = group.Add(new VocabularyKey(nameof(ContactId), "Contact", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
            
            #region Incoming Relationships
            ///Property <see cref="ContractId"/> to Vocab 'Contract.cdm.json/Contract' with Property 'ContractId'
            ///Property <see cref="CreatedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="CustomerId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="CustomerId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab '/core/applicationCommon/Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="ProductId"/> to Vocab '/core/applicationCommon/foundationCommon/Product.cdm.json/Product' with Property 'ProductId'
            ///Property <see cref="ServiceAddress"/> to Vocab '/core/applicationCommon/Address.cdm.json/Address' with Property 'CustomerAddressId'
            ///Property <see cref="UoMId"/> to Vocab '/core/applicationCommon/foundationCommon/Unit.cdm.json/Unit' with Property 'UoMId'
            ///Property <see cref="UoMScheduleId"/> to Vocab '/core/applicationCommon/foundationCommon/UnitGroup.cdm.json/UnitGroup' with Property 'UoMScheduleId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="ContractDetailId"/> from Vocab 'Case.cdm.json/Case' with Property 'ContractDetailId'
            ///Property <see cref="ContractDetailId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/solutions/portals/Case.cdm.json/Case' with Property 'ContractDetailId'
            #endregion
        }

        public VocabularyKey ContractDetailId { get; private set; }
        public VocabularyKey Title { get; private set; }
        public VocabularyKey ActiveOn { get; private set; }
        public VocabularyKey AllotmentsOverage { get; private set; }
        public VocabularyKey AllotmentsRemaining { get; private set; }
        public VocabularyKey AllotmentsUsed { get; private set; }
        public VocabularyKey ContractStateCode { get; private set; }
        public VocabularyKey Discount { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey DiscountBase { get; private set; }
        public VocabularyKey DiscountPercentage { get; private set; }
        public VocabularyKey EffectivityCalendar { get; private set; }
        public VocabularyKey ExpiresOn { get; private set; }
        public VocabularyKey InitialQuantity { get; private set; }
        public VocabularyKey LineItemOrder { get; private set; }
        public VocabularyKey Net { get; private set; }
        public VocabularyKey NetBase { get; private set; }
        public VocabularyKey Price { get; private set; }
        public VocabularyKey PriceBase { get; private set; }
        public VocabularyKey ProductSerialNumber { get; private set; }
        public VocabularyKey Rate { get; private set; }
        public VocabularyKey RateBase { get; private set; }
        public VocabularyKey ServiceContractUnitsCode { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey TotalAllotments { get; private set; }
        public VocabularyKey AccountId { get; private set; }
        public VocabularyKey ContactId { get; private set; }
    }
}