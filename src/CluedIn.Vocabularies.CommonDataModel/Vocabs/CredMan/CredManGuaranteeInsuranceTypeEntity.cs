using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CredManGuaranteeInsuranceTypeEntityVocabulary : SimpleVocabulary
    {
        public CredManGuaranteeInsuranceTypeEntityVocabulary()
        {
            VocabularyName = "Common Data Model CredManGuaranteeInsuranceTypeEntity";
            KeyPrefix = "commonDataModel.credmanguaranteeinsurancetypeentity";
            KeySeparator = ".";
            Grouping = "/CredManGuaranteeInsuranceTypeEntity";

            AddGroup("Common Data Model CredManGuaranteeInsuranceTypeEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Type = group.Add(new VocabularyKey(nameof(Type), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Description { get; private set; }
public VocabularyKey Type { get; private set; }


    }
}