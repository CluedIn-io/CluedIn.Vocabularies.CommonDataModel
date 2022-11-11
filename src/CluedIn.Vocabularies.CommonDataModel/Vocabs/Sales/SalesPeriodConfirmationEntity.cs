using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SalesPeriodConfirmationEntityVocabulary : SimpleVocabulary
    {
        public SalesPeriodConfirmationEntityVocabulary()
        {
            VocabularyName = "SalesPeriodConfirmationEntity";
            KeyPrefix = "commonDataModel.salesperiodconfirmationentity";
            KeySeparator = ".";
            Grouping = "/SalesPeriodConfirmationEntity";

            AddGroup("SalesPeriodConfirmationEntity Details", group =>
            {
                ExportConfirmationPeriod = group.Add(new VocabularyKey(nameof(ExportConfirmationPeriod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FromDate = group.Add(new VocabularyKey(nameof(FromDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ExportConfirmationPeriod { get; private set; }
        public VocabularyKey FromDate { get; private set; }


    }
}