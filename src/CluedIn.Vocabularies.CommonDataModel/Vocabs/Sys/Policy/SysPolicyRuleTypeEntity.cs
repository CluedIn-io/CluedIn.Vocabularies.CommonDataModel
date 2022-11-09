using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SysPolicyRuleTypeEntityVocabulary : SimpleVocabulary
    {
        public SysPolicyRuleTypeEntityVocabulary()
        {
            VocabularyName = "Common Data Model SysPolicyRuleTypeEntity";
            KeyPrefix = "commonDataModel.syspolicyruletypeentity";
            KeySeparator = ".";
            Grouping = "/SysPolicyRuleTypeEntity";

            AddGroup("Common Data Model SysPolicyRuleTypeEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IncludeParentRule = group.Add(new VocabularyKey(nameof(IncludeParentRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsPrecedenceSupported = group.Add(new VocabularyKey(nameof(IsPrecedenceSupported), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RuleName = group.Add(new VocabularyKey(nameof(RuleName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PolicyTypeRel = group.Add(new VocabularyKey(nameof(PolicyTypeRel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PolicyType = group.Add(new VocabularyKey(nameof(PolicyType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PolicyName = group.Add(new VocabularyKey(nameof(PolicyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Description { get; private set; }
public VocabularyKey IncludeParentRule { get; private set; }
public VocabularyKey IsPrecedenceSupported { get; private set; }
public VocabularyKey RuleName { get; private set; }
public VocabularyKey PolicyTypeRel { get; private set; }
public VocabularyKey PolicyType { get; private set; }
public VocabularyKey PolicyName { get; private set; }


    }
}