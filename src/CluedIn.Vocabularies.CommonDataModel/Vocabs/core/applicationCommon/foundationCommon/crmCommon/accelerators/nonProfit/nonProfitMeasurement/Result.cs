using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.NonProfitMeasurement
{
    public class ResultVocabulary : SimpleVocabulary
    {
        public ResultVocabulary()
        {
            VocabularyName = "Result";
            KeyPrefix = "commonDataModel.result.nonprofitmeasurement";
            KeySeparator = ".";
            Grouping = "/Result";

            AddGroup("Result Details for NonProfitMeasurement", group =>
            {
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Name { get; private set; }
    }
}