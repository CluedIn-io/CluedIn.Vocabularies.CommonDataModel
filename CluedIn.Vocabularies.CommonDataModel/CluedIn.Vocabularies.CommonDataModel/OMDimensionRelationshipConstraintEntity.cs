using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class OMDimensionRelationshipConstraintEntityVocabulary : SimpleVocabulary
    {
        public OMDimensionRelationshipConstraintEntityVocabulary()
        {
            VocabularyName = "Common Data Model OMDimensionRelationshipConstraintEntity";
            KeyPrefix = "commonDataModel.omdimensionrelationshipconstraintentity";
            KeySeparator = ".";
            Grouping = "/OMDimensionRelationshipConstraintEntity";

            AddGroup("Common Data Model OMDimensionRelationshipConstraintEntity Details", group =>
            {
                LeftSegment = group.Add(new VocabularyKey(nameof(LeftSegment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LeftDimensionHierarchyLevel = group.Add(new VocabularyKey(nameof(LeftDimensionHierarchyLevel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LeftAccountStructureName = group.Add(new VocabularyKey(nameof(LeftAccountStructureName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LeftAccountStructureStatus = group.Add(new VocabularyKey(nameof(LeftAccountStructureStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LeftReferenceFieldName = group.Add(new VocabularyKey(nameof(LeftReferenceFieldName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OrganizationHierarchyName = group.Add(new VocabularyKey(nameof(OrganizationHierarchyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RightSegment = group.Add(new VocabularyKey(nameof(RightSegment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RightDimensionHierarchyLevel = group.Add(new VocabularyKey(nameof(RightDimensionHierarchyLevel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RightAccountStructureName = group.Add(new VocabularyKey(nameof(RightAccountStructureName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RightAccountStructureStatus = group.Add(new VocabularyKey(nameof(RightAccountStructureStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RightReferenceFieldName = group.Add(new VocabularyKey(nameof(RightReferenceFieldName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey LeftSegment { get; private set; }
public VocabularyKey LeftDimensionHierarchyLevel { get; private set; }
public VocabularyKey LeftAccountStructureName { get; private set; }
public VocabularyKey LeftAccountStructureStatus { get; private set; }
public VocabularyKey LeftReferenceFieldName { get; private set; }
public VocabularyKey OrganizationHierarchyName { get; private set; }
public VocabularyKey RightSegment { get; private set; }
public VocabularyKey RightDimensionHierarchyLevel { get; private set; }
public VocabularyKey RightAccountStructureName { get; private set; }
public VocabularyKey RightAccountStructureStatus { get; private set; }
public VocabularyKey RightReferenceFieldName { get; private set; }


    }
}