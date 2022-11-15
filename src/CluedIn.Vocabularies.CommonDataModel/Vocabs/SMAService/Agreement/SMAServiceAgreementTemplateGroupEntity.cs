using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SMAServiceAgreementTemplateGroupEntityVocabulary : SimpleVocabulary
    {
        public SMAServiceAgreementTemplateGroupEntityVocabulary()
        {
            VocabularyName = "SMA Service Agreement Template Group Entity";
            KeyPrefix = "commonDataModel.smaserviceagreementtemplategroupentity";
            KeySeparator = ".";
            Grouping = "/SMAServiceAgreementTemplateGroupEntity";

            AddGroup("SMAServiceAgreementTemplateGroupEntity Details", group =>
            {
                GroupId = group.Add(new VocabularyKey(nameof(GroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GroupDescription = group.Add(new VocabularyKey(nameof(GroupDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ParentServiceAgreementTemplateGroupId = group.Add(new VocabularyKey(nameof(ParentServiceAgreementTemplateGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey GroupId { get; private set; }
        public VocabularyKey GroupDescription { get; private set; }
        public VocabularyKey ParentServiceAgreementTemplateGroupId { get; private set; }
    }
}