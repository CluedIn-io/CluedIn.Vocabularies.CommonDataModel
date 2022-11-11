using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ElectronicTaxDeclarationParameterEntityVocabulary : SimpleVocabulary
    {
        public ElectronicTaxDeclarationParameterEntityVocabulary()
        {
            VocabularyName = "ElectronicTaxDeclarationParameterEntity";
            KeyPrefix = "commonDataModel.electronictaxdeclarationparameterentity";
            KeySeparator = ".";
            Grouping = "/ElectronicTaxDeclarationParameterEntity";

            AddGroup("ElectronicTaxDeclarationParameterEntity Details", group =>
            {
                TimeOut = group.Add(new VocabularyKey(nameof(TimeOut), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContactId = group.Add(new VocabularyKey(nameof(ContactId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VATContactType = group.Add(new VocabularyKey(nameof(VATContactType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ICPContactType = group.Add(new VocabularyKey(nameof(ICPContactType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Telephone = group.Add(new VocabularyKey(nameof(Telephone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalGroup = group.Add(new VocabularyKey(nameof(FiscalGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ID = group.Add(new VocabularyKey(nameof(ID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CompanyPartOfFiscalGroup = group.Add(new VocabularyKey(nameof(CompanyPartOfFiscalGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContactInitials = group.Add(new VocabularyKey(nameof(ContactInitials), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContactPrefix = group.Add(new VocabularyKey(nameof(ContactPrefix), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FormatMapping = group.Add(new VocabularyKey(nameof(FormatMapping), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DigipoortDeliveryURL = group.Add(new VocabularyKey(nameof(DigipoortDeliveryURL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DigipoortStatusURL = group.Add(new VocabularyKey(nameof(DigipoortStatusURL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AuthorizationAddress = group.Add(new VocabularyKey(nameof(AuthorizationAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Company = group.Add(new VocabularyKey(nameof(Company), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey TimeOut { get; private set; }
        public VocabularyKey ContactId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey VATContactType { get; private set; }
        public VocabularyKey ICPContactType { get; private set; }
        public VocabularyKey Telephone { get; private set; }
        public VocabularyKey FiscalGroup { get; private set; }
        public VocabularyKey ID { get; private set; }
        public VocabularyKey CompanyPartOfFiscalGroup { get; private set; }
        public VocabularyKey ContactInitials { get; private set; }
        public VocabularyKey ContactPrefix { get; private set; }
        public VocabularyKey FormatMapping { get; private set; }
        public VocabularyKey DigipoortDeliveryURL { get; private set; }
        public VocabularyKey DigipoortStatusURL { get; private set; }
        public VocabularyKey AuthorizationAddress { get; private set; }
        public VocabularyKey Company { get; private set; }


    }
}