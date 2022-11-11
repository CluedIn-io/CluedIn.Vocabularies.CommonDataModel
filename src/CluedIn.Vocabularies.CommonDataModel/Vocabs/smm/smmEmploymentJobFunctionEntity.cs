using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class smmEmploymentJobFunctionEntityVocabulary : SimpleVocabulary
    {
        public smmEmploymentJobFunctionEntityVocabulary()
        {
            VocabularyName = "smmEmploymentJobFunctionEntity";
            KeyPrefix = "commonDataModel.smmemploymentjobfunctionentity";
            KeySeparator = ".";
            Grouping = "/smmEmploymentJobFunctionEntity";

            AddGroup("smmEmploymentJobFunctionEntity Details", group =>
            {
                FunctionDescription = group.Add(new VocabularyKey(nameof(FunctionDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FunctionName = group.Add(new VocabularyKey(nameof(FunctionName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey FunctionDescription { get; private set; }
        public VocabularyKey FunctionName { get; private set; }


    }
}