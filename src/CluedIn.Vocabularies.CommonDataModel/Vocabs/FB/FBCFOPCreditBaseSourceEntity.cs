using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class FBCFOPCreditBaseSourceEntityVocabulary : SimpleVocabulary
    {
        public FBCFOPCreditBaseSourceEntityVocabulary()
        {
            VocabularyName = "FBCFOP Credit Base Source Entity";
            KeyPrefix = "commonDataModel.fbcfopcreditbasesourceentity";
            KeySeparator = ".";
            Grouping = "/FBCFOPCreditBaseSourceEntity";

            AddGroup("FBCFOPCreditBaseSourceEntity Details", group =>
            {
                CFOP = group.Add(new VocabularyKey(nameof(CFOP), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CFOPDescription = group.Add(new VocabularyKey(nameof(CFOPDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidFromDate = group.Add(new VocabularyKey(nameof(ValidFromDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidToDate = group.Add(new VocabularyKey(nameof(ValidToDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreditBaseSource = group.Add(new VocabularyKey(nameof(CreditBaseSource), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey CFOP { get; private set; }
        public VocabularyKey CFOPDescription { get; private set; }
        public VocabularyKey ValidFromDate { get; private set; }
        public VocabularyKey ValidToDate { get; private set; }
        public VocabularyKey CreditBaseSource { get; private set; }
    }
}