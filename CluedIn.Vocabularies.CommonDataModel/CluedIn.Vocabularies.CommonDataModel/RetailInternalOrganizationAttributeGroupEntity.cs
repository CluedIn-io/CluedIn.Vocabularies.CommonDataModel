using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailInternalOrganizationAttributeGroupEntityVocabulary : SimpleVocabulary
    {
        public RetailInternalOrganizationAttributeGroupEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailInternalOrganizationAttributeGroupEntity";
            KeyPrefix = "commonDataModel.retailinternalorganizationattributegroupentity";
            KeySeparator = ".";
            Grouping = "/RetailInternalOrganizationAttributeGroupEntity";

            AddGroup("Common Data Model RetailInternalOrganizationAttributeGroupEntity Details", group =>
            {
                AttributeGroupName = group.Add(new VocabularyKey(nameof(AttributeGroupName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PartyNumber = group.Add(new VocabularyKey(nameof(PartyNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AttributeGroupDisplayOrder = group.Add(new VocabularyKey(nameof(AttributeGroupDisplayOrder), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey AttributeGroupName { get; private set; }
public VocabularyKey PartyNumber { get; private set; }
public VocabularyKey AttributeGroupDisplayOrder { get; private set; }


    }
}