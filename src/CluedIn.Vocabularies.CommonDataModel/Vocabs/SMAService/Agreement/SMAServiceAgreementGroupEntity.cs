using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SMAServiceAgreementGroupEntityVocabulary : SimpleVocabulary
    {
        public SMAServiceAgreementGroupEntityVocabulary()
        {
            VocabularyName = "SMAServiceAgreementGroupEntity";
            KeyPrefix = "commonDataModel.smaserviceagreementgroupentity";
            KeySeparator = ".";
            Grouping = "/SMAServiceAgreementGroupEntity";

            AddGroup("SMAServiceAgreementGroupEntity Details", group =>
            {
                GroupId = group.Add(new VocabularyKey(nameof(GroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GroupDescription = group.Add(new VocabularyKey(nameof(GroupDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceLevelAgreementId = group.Add(new VocabularyKey(nameof(ServiceLevelAgreementId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey GroupId { get; private set; }
        public VocabularyKey GroupDescription { get; private set; }
        public VocabularyKey ServiceLevelAgreementId { get; private set; }


    }
}