using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.NonProfitMeasurement
{
    public class MeasurementItemVocabulary : SimpleVocabulary
    {
        public MeasurementItemVocabulary()
        {
            VocabularyName = "Measurement Item";
            KeyPrefix = "commonDataModel.measurementitem.nonprofitmeasurement";
            KeySeparator = ".";
            Grouping = "/MeasurementItem";

            AddGroup("MeasurementItem Details for NonProfitMeasurement", group =>
            {
			    EntityImage = group.Add(new VocabularyKey(nameof(EntityImage), "Icon", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Code = group.Add(new VocabularyKey(nameof(Code), "Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DataCollectionMethod = group.Add(new VocabularyKey(nameof(DataCollectionMethod), "Data Collection Method", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Denominator = group.Add(new VocabularyKey(nameof(Denominator), "Denominator", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LibraryType = group.Add(new VocabularyKey(nameof(LibraryType), "Library Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    MeasurementItemId = group.Add(new VocabularyKey(nameof(MeasurementItemId), "Measurement Item", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    MeasurementType = group.Add(new VocabularyKey(nameof(MeasurementType), "Measurement Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Numerator = group.Add(new VocabularyKey(nameof(Numerator), "Numerator", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Source = group.Add(new VocabularyKey(nameof(Source), "Source", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SourceType = group.Add(new VocabularyKey(nameof(SourceType), "Source Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Type = group.Add(new VocabularyKey(nameof(Type), "Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ValidFrom = group.Add(new VocabularyKey(nameof(ValidFrom), "Valid From", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ValidTo = group.Add(new VocabularyKey(nameof(ValidTo), "Valid To", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey EntityImage { get; private set; }
        public VocabularyKey Code { get; private set; }
        public VocabularyKey DataCollectionMethod { get; private set; }
        public VocabularyKey Denominator { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey LibraryType { get; private set; }
        public VocabularyKey MeasurementItemId { get; private set; }
        public VocabularyKey MeasurementType { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Numerator { get; private set; }
        public VocabularyKey Source { get; private set; }
        public VocabularyKey SourceType { get; private set; }
        public VocabularyKey Type { get; private set; }
        public VocabularyKey ValidFrom { get; private set; }
        public VocabularyKey ValidTo { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}