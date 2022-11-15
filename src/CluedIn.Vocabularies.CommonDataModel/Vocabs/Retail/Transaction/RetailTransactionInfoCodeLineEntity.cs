using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailTransactionInfoCodeLineEntityVocabulary : SimpleVocabulary
    {
        public RetailTransactionInfoCodeLineEntityVocabulary()
        {
            VocabularyName = "Retail Transaction Info Code Line Entity";
            KeyPrefix = "commonDataModel.retailtransactioninfocodelineentity";
            KeySeparator = ".";
            Grouping = "/RetailTransactionInfoCodeLineEntity";

            AddGroup("RetailTransactionInfoCodeLineEntity Details", group =>
            {
                Amount = group.Add(new VocabularyKey(nameof(Amount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Channel = group.Add(new VocabularyKey(nameof(Channel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InfoCodeId = group.Add(new VocabularyKey(nameof(InfoCodeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InputType = group.Add(new VocabularyKey(nameof(InputType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemTender = group.Add(new VocabularyKey(nameof(ItemTender), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ParentLineNumber = group.Add(new VocabularyKey(nameof(ParentLineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SourceCode = group.Add(new VocabularyKey(nameof(SourceCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SourceCodeTwo = group.Add(new VocabularyKey(nameof(SourceCodeTwo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SourceCodeThree = group.Add(new VocabularyKey(nameof(SourceCodeThree), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SubInfoCodeId = group.Add(new VocabularyKey(nameof(SubInfoCodeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Terminal = group.Add(new VocabularyKey(nameof(Terminal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionNumber = group.Add(new VocabularyKey(nameof(TransactionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionStatus = group.Add(new VocabularyKey(nameof(TransactionStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionType = group.Add(new VocabularyKey(nameof(TransactionType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RetailChannelTableOMOperatingUnitID = group.Add(new VocabularyKey(nameof(RetailChannelTableOMOperatingUnitID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OperatingUnitNumber = group.Add(new VocabularyKey(nameof(OperatingUnitNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalTransactionParentGuid = group.Add(new VocabularyKey(nameof(FiscalTransactionParentGuid), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BusinessDate = group.Add(new VocabularyKey(nameof(BusinessDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InfoAmount = group.Add(new VocabularyKey(nameof(InfoAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Information = group.Add(new VocabularyKey(nameof(Information), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Staff = group.Add(new VocabularyKey(nameof(Staff), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransDate = group.Add(new VocabularyKey(nameof(TransDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransTime = group.Add(new VocabularyKey(nameof(TransTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StoreNumber = group.Add(new VocabularyKey(nameof(StoreNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Amount { get; private set; }
        public VocabularyKey Channel { get; private set; }
        public VocabularyKey InfoCodeId { get; private set; }
        public VocabularyKey InputType { get; private set; }
        public VocabularyKey ItemTender { get; private set; }
        public VocabularyKey LineNumber { get; private set; }
        public VocabularyKey ParentLineNumber { get; private set; }
        public VocabularyKey SourceCode { get; private set; }
        public VocabularyKey SourceCodeTwo { get; private set; }
        public VocabularyKey SourceCodeThree { get; private set; }
        public VocabularyKey SubInfoCodeId { get; private set; }
        public VocabularyKey Terminal { get; private set; }
        public VocabularyKey TransactionNumber { get; private set; }
        public VocabularyKey TransactionStatus { get; private set; }
        public VocabularyKey TransactionType { get; private set; }
        public VocabularyKey RetailChannelTableOMOperatingUnitID { get; private set; }
        public VocabularyKey OperatingUnitNumber { get; private set; }
        public VocabularyKey FiscalTransactionParentGuid { get; private set; }
        public VocabularyKey BusinessDate { get; private set; }
        public VocabularyKey InfoAmount { get; private set; }
        public VocabularyKey Information { get; private set; }
        public VocabularyKey Staff { get; private set; }
        public VocabularyKey TransDate { get; private set; }
        public VocabularyKey TransTime { get; private set; }
        public VocabularyKey StoreNumber { get; private set; }
    }
}