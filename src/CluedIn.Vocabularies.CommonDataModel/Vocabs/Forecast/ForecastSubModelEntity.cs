using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ForecastSubModelEntityVocabulary : SimpleVocabulary
    {
        public ForecastSubModelEntityVocabulary()
        {
            VocabularyName = "ForecastSubModelEntity";
            KeyPrefix = "commonDataModel.forecastsubmodelentity";
            KeySeparator = ".";
            Grouping = "/ForecastSubModelEntity";

            AddGroup("ForecastSubModelEntity Details", group =>
            {
                ModelId = group.Add(new VocabularyKey(nameof(ModelId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SubModelId = group.Add(new VocabularyKey(nameof(SubModelId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SubModelName = group.Add(new VocabularyKey(nameof(SubModelName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ModelId { get; private set; }
        public VocabularyKey SubModelId { get; private set; }
        public VocabularyKey SubModelName { get; private set; }


    }
}