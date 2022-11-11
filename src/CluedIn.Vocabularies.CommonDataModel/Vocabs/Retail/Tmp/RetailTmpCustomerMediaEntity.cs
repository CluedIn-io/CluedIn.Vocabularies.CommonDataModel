using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailTmpCustomerMediaEntityVocabulary : SimpleVocabulary
    {
        public RetailTmpCustomerMediaEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailTmpCustomerMediaEntity";
            KeyPrefix = "commonDataModel.retailtmpcustomermediaentity";
            KeySeparator = ".";
            Grouping = "/RetailTmpCustomerMediaEntity";

            AddGroup("Common Data Model RetailTmpCustomerMediaEntity Details", group =>
            {
                Customer = group.Add(new VocabularyKey(nameof(Customer), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerName = group.Add(new VocabularyKey(nameof(CustomerName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FileName = group.Add(new VocabularyKey(nameof(FileName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Url = group.Add(new VocabularyKey(nameof(Url), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CompanyCode = group.Add(new VocabularyKey(nameof(CompanyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AssociationStatus = group.Add(new VocabularyKey(nameof(AssociationStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Customer { get; private set; }
        public VocabularyKey CustomerName { get; private set; }
        public VocabularyKey FileName { get; private set; }
        public VocabularyKey Url { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey CompanyCode { get; private set; }
        public VocabularyKey AssociationStatus { get; private set; }


    }
}