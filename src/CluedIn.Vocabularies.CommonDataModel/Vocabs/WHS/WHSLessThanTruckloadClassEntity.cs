using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSLessThanTruckloadClassEntityVocabulary : SimpleVocabulary
    {
        public WHSLessThanTruckloadClassEntityVocabulary()
        {
            VocabularyName = "WHS Less Than Truckload Class Entity";
            KeyPrefix = "commonDataModel.whslessthantruckloadclassentity";
            KeySeparator = ".";
            Grouping = "/WHSLessThanTruckloadClassEntity";

            AddGroup("WHSLessThanTruckloadClassEntity Details", group =>
            {
                Class = group.Add(new VocabularyKey(nameof(Class), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ClassCode = group.Add(new VocabularyKey(nameof(ClassCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ClassName = group.Add(new VocabularyKey(nameof(ClassName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Class { get; private set; }
        public VocabularyKey ClassCode { get; private set; }
        public VocabularyKey ClassName { get; private set; }
    }
}