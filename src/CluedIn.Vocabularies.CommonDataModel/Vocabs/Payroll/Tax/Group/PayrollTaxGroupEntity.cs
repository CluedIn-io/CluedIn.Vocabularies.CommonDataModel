using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PayrollTaxGroupEntityVocabulary : SimpleVocabulary
    {
        public PayrollTaxGroupEntityVocabulary()
        {
            VocabularyName = "Common Data Model PayrollTaxGroupEntity";
            KeyPrefix = "commonDataModel.payrolltaxgroupentity";
            KeySeparator = ".";
            Grouping = "/PayrollTaxGroupEntity";

            AddGroup("Common Data Model PayrollTaxGroupEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
GroupId = group.Add(new VocabularyKey(nameof(GroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsEnabledForPostingDefinition = group.Add(new VocabularyKey(nameof(IsEnabledForPostingDefinition), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsImmutable = group.Add(new VocabularyKey(nameof(IsImmutable), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Description { get; private set; }
public VocabularyKey GroupId { get; private set; }
public VocabularyKey IsEnabledForPostingDefinition { get; private set; }
public VocabularyKey IsImmutable { get; private set; }


    }
}