using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class OfficialsTableDataEntityVocabulary : SimpleVocabulary
    {
        public OfficialsTableDataEntityVocabulary()
        {
            VocabularyName = "Common Data Model OfficialsTableDataEntity";
            KeyPrefix = "commonDataModel.officialstabledataentity";
            KeySeparator = ".";
            Grouping = "/OfficialsTableDataEntity";

            AddGroup("Common Data Model OfficialsTableDataEntity Details", group =>
            {
                ReportType = group.Add(new VocabularyKey(nameof(ReportType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AccountCode = group.Add(new VocabularyKey(nameof(AccountCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AccountRelation = group.Add(new VocabularyKey(nameof(AccountRelation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Warehouse = group.Add(new VocabularyKey(nameof(Warehouse), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AssociationWithWarehouse = group.Add(new VocabularyKey(nameof(AssociationWithWarehouse), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Position = group.Add(new VocabularyKey(nameof(Position), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
JobTitle = group.Add(new VocabularyKey(nameof(JobTitle), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReprReason = group.Add(new VocabularyKey(nameof(ReprReason), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReprTitleName = group.Add(new VocabularyKey(nameof(ReprTitleName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey ReportType { get; private set; }
public VocabularyKey AccountCode { get; private set; }
public VocabularyKey AccountRelation { get; private set; }
public VocabularyKey Warehouse { get; private set; }
public VocabularyKey AssociationWithWarehouse { get; private set; }
public VocabularyKey Position { get; private set; }
public VocabularyKey Name { get; private set; }
public VocabularyKey JobTitle { get; private set; }
public VocabularyKey ReprReason { get; private set; }
public VocabularyKey ReprTitleName { get; private set; }


    }
}