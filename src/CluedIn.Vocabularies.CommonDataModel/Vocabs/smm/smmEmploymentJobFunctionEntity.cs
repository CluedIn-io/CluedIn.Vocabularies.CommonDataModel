using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SmmEmploymentJobFunctionEntityVocabulary : SimpleVocabulary
    {
        public SmmEmploymentJobFunctionEntityVocabulary()
        {
            VocabularyName = "Smm Employment Job Function Entity";
            KeyPrefix = "commonDataModel.smmemploymentjobfunctionentity";
            KeySeparator = ".";
            Grouping = "/SmmEmploymentJobFunctionEntity";

            AddGroup("SmmEmploymentJobFunctionEntity Details", group =>
            {
                FunctionDescription = group.Add(new VocabularyKey(nameof(FunctionDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FunctionName = group.Add(new VocabularyKey(nameof(FunctionName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey FunctionDescription { get; private set; }
        public VocabularyKey FunctionName { get; private set; }
    }
}