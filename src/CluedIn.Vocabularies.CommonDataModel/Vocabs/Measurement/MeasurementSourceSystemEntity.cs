using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class MeasurementSourceSystemEntityVocabulary : SimpleVocabulary
    {
        public MeasurementSourceSystemEntityVocabulary()
        {
            VocabularyName = "MeasurementSourceSystemEntity";
            KeyPrefix = "commonDataModel.measurementsourcesystementity";
            KeySeparator = ".";
            Grouping = "/MeasurementSourceSystemEntity";

            AddGroup("MeasurementSourceSystemEntity Details", group =>
            {
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Name { get; private set; }
        public VocabularyKey Description { get; private set; }


    }
}