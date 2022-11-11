using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CredManInsuranceCoverageTypeEntityVocabulary : SimpleVocabulary
    {
        public CredManInsuranceCoverageTypeEntityVocabulary()
        {
            VocabularyName = "CredManInsuranceCoverageTypeEntity";
            KeyPrefix = "commonDataModel.credmaninsurancecoveragetypeentity";
            KeySeparator = ".";
            Grouping = "/CredManInsuranceCoverageTypeEntity";

            AddGroup("CredManInsuranceCoverageTypeEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Type = group.Add(new VocabularyKey(nameof(Type), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Description { get; private set; }
        public VocabularyKey Type { get; private set; }


    }
}