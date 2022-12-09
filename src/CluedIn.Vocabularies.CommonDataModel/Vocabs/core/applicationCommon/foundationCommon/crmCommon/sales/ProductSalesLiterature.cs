using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class ProductSalesLiteratureVocabulary : SimpleVocabulary
    {
        public ProductSalesLiteratureVocabulary()
        {
            VocabularyName = "Product Sales Literature";
            KeyPrefix = "commonDataModel.productsalesliterature";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.ProductSalesLiterature;

            AddGroup("ProductSalesLiterature Details for Sales", group =>
            {
			    ProductSalesLiteratureId = group.Add(new VocabularyKey(nameof(ProductSalesLiteratureId), "Unique identifier of the product sales literature associated with this price list.", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    VersionNumber = group.Add(new VocabularyKey(nameof(VersionNumber), "Version Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ImportSequenceNumber = group.Add(new VocabularyKey(nameof(ImportSequenceNumber), "Import Sequence Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    OverriddenCreatedOn = group.Add(new VocabularyKey(nameof(OverriddenCreatedOn), "Record Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TimeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(TimeZoneRuleVersionNumber), "Time Zone Rule Version Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), "UTC Conversion Time Zone Code", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
            });
            
            #region Incoming Relationships
            ///Property <see cref="ProductId"/> to Vocab '/core/applicationCommon/foundationCommon/Product.cdm.json/Product' with Property 'ProductId'
            ///Property <see cref="SalesLiteratureId"/> to Vocab 'SalesLiterature.cdm.json/SalesLiterature' with Property 'SalesLiteratureId'
            #endregion
            
            #region Outgoing Relationships
            
            #endregion
        }

        public VocabularyKey ImportSequenceNumber { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey ProductSalesLiteratureId { get; private set; }
        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
        public VocabularyKey VersionNumber { get; private set; }
    }
}