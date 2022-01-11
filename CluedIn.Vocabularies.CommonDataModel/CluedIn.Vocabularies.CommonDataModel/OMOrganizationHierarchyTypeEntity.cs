using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class OMOrganizationHierarchyTypeEntityVocabulary : SimpleVocabulary
    {
        public OMOrganizationHierarchyTypeEntityVocabulary()
        {
            VocabularyName = "Common Data Model OMOrganizationHierarchyTypeEntity";
            KeyPrefix = "commonDataModel.omorganizationhierarchytypeentity";
            KeySeparator = ".";
            Grouping = "/OMOrganizationHierarchyTypeEntity";

            AddGroup("Common Data Model OMOrganizationHierarchyTypeEntity Details", group =>
            {
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RelationshipTypeID = group.Add(new VocabularyKey(nameof(RelationshipTypeID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Name { get; private set; }
public VocabularyKey RelationshipTypeID { get; private set; }


    }
}