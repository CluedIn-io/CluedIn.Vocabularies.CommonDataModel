using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSLaborStandardLineEntityVocabulary : SimpleVocabulary
    {
        public WHSLaborStandardLineEntityVocabulary()
        {
            VocabularyName = "Common Data Model WHSLaborStandardLineEntity";
            KeyPrefix = "commonDataModel.whslaborstandardlineentity";
            KeySeparator = ".";
            Grouping = "/WHSLaborStandardLineEntity";

            AddGroup("Common Data Model WHSLaborStandardLineEntity Details", group =>
            {
                LaborMeasurementType = group.Add(new VocabularyKey(nameof(LaborMeasurementType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LineSequenceNumber = group.Add(new VocabularyKey(nameof(LineSequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LaborStandardId = group.Add(new VocabularyKey(nameof(LaborStandardId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
HourlyWorkUnitSymbol = group.Add(new VocabularyKey(nameof(HourlyWorkUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
HourlyEstimatedWork = group.Add(new VocabularyKey(nameof(HourlyEstimatedWork), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WarehouseWorkClassId = group.Add(new VocabularyKey(nameof(WarehouseWorkClassId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MeasurementWorkType = group.Add(new VocabularyKey(nameof(MeasurementWorkType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey LaborMeasurementType { get; private set; }
public VocabularyKey LineSequenceNumber { get; private set; }
public VocabularyKey LaborStandardId { get; private set; }
public VocabularyKey HourlyWorkUnitSymbol { get; private set; }
public VocabularyKey HourlyEstimatedWork { get; private set; }
public VocabularyKey WarehouseWorkClassId { get; private set; }
public VocabularyKey MeasurementWorkType { get; private set; }


    }
}