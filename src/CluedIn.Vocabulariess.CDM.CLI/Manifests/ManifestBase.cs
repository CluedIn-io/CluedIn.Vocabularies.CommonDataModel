using CluedIn.Core.Data.Vocabularies;
using Microsoft.CommonDataModel.ObjectModel.Cdm;
using Microsoft.CommonDataModel.ObjectModel.Storage;
using Microsoft.CommonDataModel.ObjectModel.Utilities;
using System;
using System.IO;
using System.Reflection;

namespace CluedIn.Vocabulariess.CDM.CLI
{
    public class ManifestBase
    {
        private static CdmCorpusDefinition _cdmCorpus;
        public static CdmCorpusDefinition CdmCorpus
        {
            get
            {
                if (_cdmCorpus == null)
                {
                    _cdmCorpus = new CdmCorpusDefinition();

                    _cdmCorpus.SetEventCallback(new EventCallback
                    {
                        Invoke = (level, message) =>
                        {
                            Console.WriteLine(message);
                        }
                    }, CdmStatusLevel.Warning);

                    _cdmCorpus.Storage.Mount("local", new LocalAdapter(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "SampleData")));
                    _cdmCorpus.Storage.DefaultNamespace = "local";
                }

                return _cdmCorpus;
            }
        }

        public static string MapCDMTypeToCluedInType(string type)
        {
            switch (type.ToLower())
            {
                case "addressLine":
                    return VocabularyKeyDataType.Text.ToString();
                case "baseCurrency":
                    return VocabularyKeyDataType.Currency.ToString();
                case "bigInteger":
                    return VocabularyKeyDataType.Integer.ToString();
                case "boolean":
                    return VocabularyKeyDataType.Boolean.ToString();
                case "city":
                    return VocabularyKeyDataType.Text.ToString();
                case "colorName":
                    return VocabularyKeyDataType.Color.ToString();
                case "companyName":
                    return VocabularyKeyDataType.Text.ToString();
                case "country":
                case "county":
                    return VocabularyKeyDataType.GeographyCountry.ToString();
                case "currency":
                    return VocabularyKeyDataType.Currency.ToString();
                case "date":
                case "dateTime":
                    return VocabularyKeyDataType.DateTime.ToString();
                case "decimal":
                case "double":
                    return VocabularyKeyDataType.Number.ToString();
                case "email":
                    return VocabularyKeyDataType.Email.ToString();
                case "entityId":
                    return VocabularyKeyDataType.Identifier.ToString();
                case "entityName":
                    return VocabularyKeyDataType.Text.ToString();
                case "firstName":
                    return VocabularyKeyDataType.Text.ToString();
                case "fullName":
                    return VocabularyKeyDataType.Text.ToString();
                case "governmentId":
                    return VocabularyKeyDataType.Text.ToString();
                case "guid":
                    return VocabularyKeyDataType.Guid.ToString();
                case "image":
                    return VocabularyKeyDataType.Text.ToString();
                case "integer":
                    return VocabularyKeyDataType.Integer.ToString();
                case "language":
                    return VocabularyKeyDataType.Text.ToString();
                case "lastName":
                    return VocabularyKeyDataType.Text.ToString();
                case "latitude":
                    return VocabularyKeyDataType.Text.ToString();
                case "listLookup":
                    return VocabularyKeyDataType.Text.ToString();
                case "listLookupCorrelated":
                    return VocabularyKeyDataType.Text.ToString();
                case "listLookupMultiple":
                    return VocabularyKeyDataType.Text.ToString();
                case "longitude":
                    return VocabularyKeyDataType.Text.ToString();
                case "middleName":
                    return VocabularyKeyDataType.Text.ToString();
                case "month":
                    return VocabularyKeyDataType.Text.ToString();
                case "name":
                    return VocabularyKeyDataType.Text.ToString();
                case "partylist":
                    return VocabularyKeyDataType.Text.ToString();
                case "phone":
                    return VocabularyKeyDataType.PhoneNumber.ToString();
                case "phoneFax":
                    return VocabularyKeyDataType.PhoneNumber.ToString();
                case "postalCode":
                    return VocabularyKeyDataType.Text.ToString();
                case "smallInteger":
                    return VocabularyKeyDataType.Integer.ToString();
                case "stateOrProvince":
                    return VocabularyKeyDataType.GeographyState.ToString();
                case "string":
                    return VocabularyKeyDataType.Text.ToString();
                case "tickerSymbol":
                    return VocabularyKeyDataType.Text.ToString();
                case "timezone":
                    return VocabularyKeyDataType.TimeZone.ToString();
                case "url":
                    return VocabularyKeyDataType.Uri.ToString();
                default:
                    return VocabularyKeyDataType.Text.ToString();
            }
        }
    }
}
