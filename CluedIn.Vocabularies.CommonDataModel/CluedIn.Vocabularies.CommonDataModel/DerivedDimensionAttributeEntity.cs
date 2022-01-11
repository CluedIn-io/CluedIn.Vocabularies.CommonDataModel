using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class DerivedDimensionAttributeEntityVocabulary : SimpleVocabulary
    {
        public DerivedDimensionAttributeEntityVocabulary()
        {
            VocabularyName = "Common Data Model DerivedDimensionAttributeEntity";
            KeyPrefix = "commonDataModel.deriveddimensionattributeentity";
            KeySeparator = ".";
            Grouping = "/DerivedDimensionAttributeEntity";

            AddGroup("Common Data Model DerivedDimensionAttributeEntity Details", group =>
            {
                DrivingDimension = group.Add(new VocabularyKey(nameof(DrivingDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DerivedDimension1 = group.Add(new VocabularyKey(nameof(DerivedDimension1), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PreventChanges1 = group.Add(new VocabularyKey(nameof(PreventChanges1), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DerivedDimension2 = group.Add(new VocabularyKey(nameof(DerivedDimension2), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PreventChanges2 = group.Add(new VocabularyKey(nameof(PreventChanges2), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DerivedDimension3 = group.Add(new VocabularyKey(nameof(DerivedDimension3), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PreventChanges3 = group.Add(new VocabularyKey(nameof(PreventChanges3), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DerivedDimension4 = group.Add(new VocabularyKey(nameof(DerivedDimension4), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PreventChanges4 = group.Add(new VocabularyKey(nameof(PreventChanges4), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DerivedDimension5 = group.Add(new VocabularyKey(nameof(DerivedDimension5), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PreventChanges5 = group.Add(new VocabularyKey(nameof(PreventChanges5), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DerivedDimension6 = group.Add(new VocabularyKey(nameof(DerivedDimension6), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PreventChanges6 = group.Add(new VocabularyKey(nameof(PreventChanges6), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DerivedDimension7 = group.Add(new VocabularyKey(nameof(DerivedDimension7), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PreventChanges7 = group.Add(new VocabularyKey(nameof(PreventChanges7), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DerivedDimension8 = group.Add(new VocabularyKey(nameof(DerivedDimension8), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PreventChanges8 = group.Add(new VocabularyKey(nameof(PreventChanges8), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DerivedDimension9 = group.Add(new VocabularyKey(nameof(DerivedDimension9), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PreventChanges9 = group.Add(new VocabularyKey(nameof(PreventChanges9), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DerivedDimension10 = group.Add(new VocabularyKey(nameof(DerivedDimension10), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PreventChanges10 = group.Add(new VocabularyKey(nameof(PreventChanges10), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
HierarchyName = group.Add(new VocabularyKey(nameof(HierarchyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
HierarchyStatus = group.Add(new VocabularyKey(nameof(HierarchyStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
HierarchyType = group.Add(new VocabularyKey(nameof(HierarchyType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey DrivingDimension { get; private set; }
public VocabularyKey DerivedDimension1 { get; private set; }
public VocabularyKey PreventChanges1 { get; private set; }
public VocabularyKey DerivedDimension2 { get; private set; }
public VocabularyKey PreventChanges2 { get; private set; }
public VocabularyKey DerivedDimension3 { get; private set; }
public VocabularyKey PreventChanges3 { get; private set; }
public VocabularyKey DerivedDimension4 { get; private set; }
public VocabularyKey PreventChanges4 { get; private set; }
public VocabularyKey DerivedDimension5 { get; private set; }
public VocabularyKey PreventChanges5 { get; private set; }
public VocabularyKey DerivedDimension6 { get; private set; }
public VocabularyKey PreventChanges6 { get; private set; }
public VocabularyKey DerivedDimension7 { get; private set; }
public VocabularyKey PreventChanges7 { get; private set; }
public VocabularyKey DerivedDimension8 { get; private set; }
public VocabularyKey PreventChanges8 { get; private set; }
public VocabularyKey DerivedDimension9 { get; private set; }
public VocabularyKey PreventChanges9 { get; private set; }
public VocabularyKey DerivedDimension10 { get; private set; }
public VocabularyKey PreventChanges10 { get; private set; }
public VocabularyKey HierarchyName { get; private set; }
public VocabularyKey HierarchyStatus { get; private set; }
public VocabularyKey HierarchyType { get; private set; }


    }
}