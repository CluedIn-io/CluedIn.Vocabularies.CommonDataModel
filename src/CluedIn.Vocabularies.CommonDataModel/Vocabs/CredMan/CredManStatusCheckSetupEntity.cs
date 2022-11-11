using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CredManStatusCheckSetupEntityVocabulary : SimpleVocabulary
    {
        public CredManStatusCheckSetupEntityVocabulary()
        {
            VocabularyName = "CredManStatusCheckSetupEntity";
            KeyPrefix = "commonDataModel.credmanstatuschecksetupentity";
            KeySeparator = ".";
            Grouping = "/CredManStatusCheckSetupEntity";

            AddGroup("CredManStatusCheckSetupEntity Details", group =>
            {
                DocumentStatus = group.Add(new VocabularyKey(nameof(DocumentStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HoldType = group.Add(new VocabularyKey(nameof(HoldType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Proforma = group.Add(new VocabularyKey(nameof(Proforma), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GraceDays = group.Add(new VocabularyKey(nameof(GraceDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey DocumentStatus { get; private set; }
        public VocabularyKey HoldType { get; private set; }
        public VocabularyKey Proforma { get; private set; }
        public VocabularyKey GraceDays { get; private set; }


    }
}