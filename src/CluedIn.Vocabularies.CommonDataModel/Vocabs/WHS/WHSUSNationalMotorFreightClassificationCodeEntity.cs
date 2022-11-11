using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSUSNationalMotorFreightClassificationCodeEntityVocabulary : SimpleVocabulary
    {
        public WHSUSNationalMotorFreightClassificationCodeEntityVocabulary()
        {
            VocabularyName = "WHSUSNationalMotorFreightClassificationCodeEntity";
            KeyPrefix = "commonDataModel.whsusnationalmotorfreightclassificationcodeentity";
            KeySeparator = ".";
            Grouping = "/WHSUSNationalMotorFreightClassificationCodeEntity";

            AddGroup("WHSUSNationalMotorFreightClassificationCodeEntity Details", group =>
            {
                DefaultBillOfLadingHandlingType = group.Add(new VocabularyKey(nameof(DefaultBillOfLadingHandlingType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LTLClassCode = group.Add(new VocabularyKey(nameof(LTLClassCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NMFCName = group.Add(new VocabularyKey(nameof(NMFCName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NMFCCode = group.Add(new VocabularyKey(nameof(NMFCCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey DefaultBillOfLadingHandlingType { get; private set; }
        public VocabularyKey LTLClassCode { get; private set; }
        public VocabularyKey NMFCName { get; private set; }
        public VocabularyKey NMFCCode { get; private set; }


    }
}