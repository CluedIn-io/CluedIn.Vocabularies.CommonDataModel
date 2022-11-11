using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class VendSettlementTax1099EntityVocabulary : SimpleVocabulary
    {
        public VendSettlementTax1099EntityVocabulary()
        {
            VocabularyName = "Common Data Model VendSettlementTax1099Entity";
            KeyPrefix = "commonDataModel.vendsettlementtax1099entity";
            KeySeparator = ".";
            Grouping = "/VendSettlementTax1099Entity";

            AddGroup("Common Data Model VendSettlementTax1099Entity Details", group =>
            {
                VendorAccount = group.Add(new VocabularyKey(nameof(VendorAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransDate = group.Add(new VocabularyKey(nameof(TransDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SettledFederal1099 = group.Add(new VocabularyKey(nameof(SettledFederal1099), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CountryRegion = group.Add(new VocabularyKey(nameof(CountryRegion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                State = group.Add(new VocabularyKey(nameof(State), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SettledState1099 = group.Add(new VocabularyKey(nameof(SettledState1099), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ManualEntry = group.Add(new VocabularyKey(nameof(ManualEntry), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                G10aState = group.Add(new VocabularyKey(nameof(G10aState), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                G10bStateIdNumber = group.Add(new VocabularyKey(nameof(G10bStateIdNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                G11StateIncomeTaxWithheld = group.Add(new VocabularyKey(nameof(G11StateIncomeTaxWithheld), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                G3TaxYear = group.Add(new VocabularyKey(nameof(G3TaxYear), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                G8TradeOrBusinessIncome = group.Add(new VocabularyKey(nameof(G8TradeOrBusinessIncome), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                S1DateOfClosing = group.Add(new VocabularyKey(nameof(S1DateOfClosing), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                S3AddressOrLegalDescription = group.Add(new VocabularyKey(nameof(S3AddressOrLegalDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                S4TransferorRecievedProperty = group.Add(new VocabularyKey(nameof(S4TransferorRecievedProperty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                S5BuyerPartOfRealEstateTax = group.Add(new VocabularyKey(nameof(S5BuyerPartOfRealEstateTax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Tax1099BoxIdRef = group.Add(new VocabularyKey(nameof(Tax1099BoxIdRef), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Tax1099BoxId = group.Add(new VocabularyKey(nameof(Tax1099BoxId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Tax1099Type = group.Add(new VocabularyKey(nameof(Tax1099Type), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RecordId = group.Add(new VocabularyKey(nameof(RecordId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey VendorAccount { get; private set; }
        public VocabularyKey TransDate { get; private set; }
        public VocabularyKey SettledFederal1099 { get; private set; }
        public VocabularyKey CountryRegion { get; private set; }
        public VocabularyKey State { get; private set; }
        public VocabularyKey SettledState1099 { get; private set; }
        public VocabularyKey ManualEntry { get; private set; }
        public VocabularyKey G10aState { get; private set; }
        public VocabularyKey G10bStateIdNumber { get; private set; }
        public VocabularyKey G11StateIncomeTaxWithheld { get; private set; }
        public VocabularyKey G3TaxYear { get; private set; }
        public VocabularyKey G8TradeOrBusinessIncome { get; private set; }
        public VocabularyKey S1DateOfClosing { get; private set; }
        public VocabularyKey S3AddressOrLegalDescription { get; private set; }
        public VocabularyKey S4TransferorRecievedProperty { get; private set; }
        public VocabularyKey S5BuyerPartOfRealEstateTax { get; private set; }
        public VocabularyKey Tax1099BoxIdRef { get; private set; }
        public VocabularyKey Tax1099BoxId { get; private set; }
        public VocabularyKey Tax1099Type { get; private set; }
        public VocabularyKey RecordId { get; private set; }


    }
}