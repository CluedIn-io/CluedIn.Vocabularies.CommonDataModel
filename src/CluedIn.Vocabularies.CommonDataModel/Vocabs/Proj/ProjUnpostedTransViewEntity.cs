using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProjUnpostedTransViewEntityVocabulary : SimpleVocabulary
    {
        public ProjUnpostedTransViewEntityVocabulary()
        {
            VocabularyName = "Proj Unposted Trans View Entity";
            KeyPrefix = "commonDataModel.projunpostedtransviewentity";
            KeySeparator = ".";
            Grouping = "/ProjUnpostedTransViewEntity";

            AddGroup("ProjUnpostedTransViewEntity Details", group =>
            {
                ActivityNumber = group.Add(new VocabularyKey(nameof(ActivityNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Amount = group.Add(new VocabularyKey(nameof(Amount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CategoryId = group.Add(new VocabularyKey(nameof(CategoryId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CostPrice = group.Add(new VocabularyKey(nameof(CostPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CurrencyId = group.Add(new VocabularyKey(nameof(CurrencyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DataAreaIdUnion = group.Add(new VocabularyKey(nameof(DataAreaIdUnion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemId = group.Add(new VocabularyKey(nameof(ItemId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LinePropertyId = group.Add(new VocabularyKey(nameof(LinePropertyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectId = group.Add(new VocabularyKey(nameof(ProjectId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Quantity = group.Add(new VocabularyKey(nameof(Quantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ResourceName = group.Add(new VocabularyKey(nameof(ResourceName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesPrice = group.Add(new VocabularyKey(nameof(SalesPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionOrigin = group.Add(new VocabularyKey(nameof(TransactionOrigin), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionDataAreaId = group.Add(new VocabularyKey(nameof(TransactionDataAreaId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionDate = group.Add(new VocabularyKey(nameof(TransactionDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionId = group.Add(new VocabularyKey(nameof(TransactionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionType = group.Add(new VocabularyKey(nameof(TransactionType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ActivityNumber { get; private set; }
        public VocabularyKey Amount { get; private set; }
        public VocabularyKey CategoryId { get; private set; }
        public VocabularyKey CostPrice { get; private set; }
        public VocabularyKey CurrencyId { get; private set; }
        public VocabularyKey DataAreaIdUnion { get; private set; }
        public VocabularyKey ItemId { get; private set; }
        public VocabularyKey LinePropertyId { get; private set; }
        public VocabularyKey ProjectId { get; private set; }
        public VocabularyKey Quantity { get; private set; }
        public VocabularyKey ResourceName { get; private set; }
        public VocabularyKey SalesPrice { get; private set; }
        public VocabularyKey TransactionOrigin { get; private set; }
        public VocabularyKey TransactionDataAreaId { get; private set; }
        public VocabularyKey TransactionDate { get; private set; }
        public VocabularyKey TransactionId { get; private set; }
        public VocabularyKey TransactionType { get; private set; }
    }
}