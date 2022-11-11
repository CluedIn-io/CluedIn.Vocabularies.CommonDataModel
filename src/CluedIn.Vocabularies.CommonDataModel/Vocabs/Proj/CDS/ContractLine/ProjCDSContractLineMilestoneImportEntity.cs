using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProjCDSContractLineMilestoneImportEntityVocabulary : SimpleVocabulary
    {
        public ProjCDSContractLineMilestoneImportEntityVocabulary()
        {
            VocabularyName = "Common Data Model ProjCDSContractLineMilestoneImportEntity";
            KeyPrefix = "commonDataModel.projcdscontractlinemilestoneimportentity";
            KeySeparator = ".";
            Grouping = "/ProjCDSContractLineMilestoneImportEntity";

            AddGroup("Common Data Model ProjCDSContractLineMilestoneImportEntity Details", group =>
            {
                TransactionId = group.Add(new VocabularyKey(nameof(TransactionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContractLineRef = group.Add(new VocabularyKey(nameof(ContractLineRef), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceDate = group.Add(new VocabularyKey(nameof(InvoiceDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CurrencyId = group.Add(new VocabularyKey(nameof(CurrencyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Amount = group.Add(new VocabularyKey(nameof(Amount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey TransactionId { get; private set; }
        public VocabularyKey ContractLineRef { get; private set; }
        public VocabularyKey InvoiceDate { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey CurrencyId { get; private set; }
        public VocabularyKey Amount { get; private set; }


    }
}