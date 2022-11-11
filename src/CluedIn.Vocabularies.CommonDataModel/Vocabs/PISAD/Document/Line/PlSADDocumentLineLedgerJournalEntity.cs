using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PlSADDocumentLineLedgerJournalEntityVocabulary : SimpleVocabulary
    {
        public PlSADDocumentLineLedgerJournalEntityVocabulary()
        {
            VocabularyName = "PlSADDocumentLineLedgerJournalEntity";
            KeyPrefix = "commonDataModel.plsaddocumentlineledgerjournalentity";
            KeySeparator = ".";
            Grouping = "/PlSADDocumentLineLedgerJournalEntity";

            AddGroup("PlSADDocumentLineLedgerJournalEntity Details", group =>
            {
                BaseForSAD = group.Add(new VocabularyKey(nameof(BaseForSAD), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SADDate = group.Add(new VocabularyKey(nameof(SADDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Duty = group.Add(new VocabularyKey(nameof(Duty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Excise = group.Add(new VocabularyKey(nameof(Excise), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Position = group.Add(new VocabularyKey(nameof(Position), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SADNumber = group.Add(new VocabularyKey(nameof(SADNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesTaxAmount = group.Add(new VocabularyKey(nameof(SalesTaxAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesTaxCode = group.Add(new VocabularyKey(nameof(SalesTaxCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey BaseForSAD { get; private set; }
        public VocabularyKey SADDate { get; private set; }
        public VocabularyKey Duty { get; private set; }
        public VocabularyKey Excise { get; private set; }
        public VocabularyKey Position { get; private set; }
        public VocabularyKey SADNumber { get; private set; }
        public VocabularyKey SalesTaxAmount { get; private set; }
        public VocabularyKey SalesTaxCode { get; private set; }


    }
}