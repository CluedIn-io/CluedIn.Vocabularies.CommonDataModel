using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CustCustomerStatisticsGroupEntityVocabulary : SimpleVocabulary
    {
        public CustCustomerStatisticsGroupEntityVocabulary()
        {
            VocabularyName = "CustCustomerStatisticsGroupEntity";
            KeyPrefix = "commonDataModel.custcustomerstatisticsgroupentity";
            KeySeparator = ".";
            Grouping = "/CustCustomerStatisticsGroupEntity";

            AddGroup("CustCustomerStatisticsGroupEntity Details", group =>
            {
                StatisticsGroup = group.Add(new VocabularyKey(nameof(StatisticsGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey StatisticsGroup { get; private set; }
        public VocabularyKey Description { get; private set; }


    }
}