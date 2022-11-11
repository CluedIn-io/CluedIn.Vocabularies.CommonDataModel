using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProjProjectTransferPriceV2EntityVocabulary : SimpleVocabulary
    {
        public ProjProjectTransferPriceV2EntityVocabulary()
        {
            VocabularyName = "ProjProjectTransferPriceV2Entity";
            KeyPrefix = "commonDataModel.projprojecttransferpricev2entity";
            KeySeparator = ".";
            Grouping = "/ProjProjectTransferPriceV2Entity";

            AddGroup("ProjProjectTransferPriceV2Entity Details", group =>
            {
                SalesCurrency = group.Add(new VocabularyKey(nameof(SalesCurrency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransferPriceModel = group.Add(new VocabularyKey(nameof(TransferPriceModel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjCategory = group.Add(new VocabularyKey(nameof(ProjCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BorrowingLegalEntity = group.Add(new VocabularyKey(nameof(BorrowingLegalEntity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjInvoiceTable = group.Add(new VocabularyKey(nameof(ProjInvoiceTable), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjTable = group.Add(new VocabularyKey(nameof(ProjTable), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Resource = group.Add(new VocabularyKey(nameof(Resource), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ResourceCategory = group.Add(new VocabularyKey(nameof(ResourceCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EffectiveDate = group.Add(new VocabularyKey(nameof(EffectiveDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Pricing = group.Add(new VocabularyKey(nameof(Pricing), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionType = group.Add(new VocabularyKey(nameof(TransactionType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ResourceId = group.Add(new VocabularyKey(nameof(ResourceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectId = group.Add(new VocabularyKey(nameof(ProjectId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CategoryId = group.Add(new VocabularyKey(nameof(CategoryId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectContractId = group.Add(new VocabularyKey(nameof(ProjectContractId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RoleId = group.Add(new VocabularyKey(nameof(RoleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey SalesCurrency { get; private set; }
        public VocabularyKey TransferPriceModel { get; private set; }
        public VocabularyKey ProjCategory { get; private set; }
        public VocabularyKey BorrowingLegalEntity { get; private set; }
        public VocabularyKey ProjInvoiceTable { get; private set; }
        public VocabularyKey ProjTable { get; private set; }
        public VocabularyKey Resource { get; private set; }
        public VocabularyKey ResourceCategory { get; private set; }
        public VocabularyKey EffectiveDate { get; private set; }
        public VocabularyKey Pricing { get; private set; }
        public VocabularyKey TransactionType { get; private set; }
        public VocabularyKey ResourceId { get; private set; }
        public VocabularyKey ProjectId { get; private set; }
        public VocabularyKey CategoryId { get; private set; }
        public VocabularyKey ProjectContractId { get; private set; }
        public VocabularyKey RoleId { get; private set; }


    }
}