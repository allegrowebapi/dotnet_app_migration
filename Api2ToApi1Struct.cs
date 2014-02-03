namespace allegrowebapi
{
    public partial class ActionDataStruct {
        [System.Xml.Serialization.XmlIgnore]
        public string actionkey    
        {
            get
            {
                return this.actionKey;
            }
            set
            {
                this.actionKey = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string actionvalue    
        {
            get
            {
                return this.actionValue;
            }
            set
            {
                this.actionValue = value;
                            
            }
        }
    }

    public partial class AddressInfoStruct {
        [System.Xml.Serialization.XmlIgnore]
        public int addresstype    
        {
            get
            {
                return this.addressType;
            }
            set
            {
                this.addressType = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public AddressUserDataStruct addressuserdata    
        {
            get
            {
                return this.addressUserData;
            }
            set
            {
                this.addressUserData = value;
                            
            }
        }
    }

    public partial class AddressUserDataStruct {
        [System.Xml.Serialization.XmlIgnore]
        public string usercompany    
        {
            get
            {
                return this.userCompany;
            }
            set
            {
                this.userCompany = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string userfullname    
        {
            get
            {
                return this.userFullName;
            }
            set
            {
                this.userFullName = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string useraddress    
        {
            get
            {
                return this.userAddress;
            }
            set
            {
                this.userAddress = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string userpostcode    
        {
            get
            {
                return this.userPostcode;
            }
            set
            {
                this.userPostcode = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string usercity    
        {
            get
            {
                return this.userCity;
            }
            set
            {
                this.userCity = value;
                            
            }
        }
    }

    public partial class AdvertInfoStruct {
        [System.Xml.Serialization.XmlIgnore]
        public int itemisadvert    
        {
            get
            {
                return this.itemIsAdvert;
            }
            set
            {
                this.itemIsAdvert = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string itemadvertid    
        {
            get
            {
                return this.itemAdvertId;
            }
            set
            {
                this.itemAdvertId = value;
                            
            }
        }
    }

    public partial class AlcoholDataStruct {
        [System.Xml.Serialization.XmlIgnore]
        public string alcoholopeningdate    
        {
            get
            {
                return this.alcoholOpeningDate;
            }
            set
            {
                this.alcoholOpeningDate = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string alcoholexpirationdate    
        {
            get
            {
                return this.alcoholExpirationDate;
            }
            set
            {
                this.alcoholExpirationDate = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string alcoholshopname    
        {
            get
            {
                return this.alcoholShopName;
            }
            set
            {
                this.alcoholShopName = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string alcoholshopaddress    
        {
            get
            {
                return this.alcoholShopAddress;
            }
            set
            {
                this.alcoholShopAddress = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string alcoholshoppostcode    
        {
            get
            {
                return this.alcoholShopPostcode;
            }
            set
            {
                this.alcoholShopPostcode = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string alcoholshopcity    
        {
            get
            {
                return this.alcoholShopCity;
            }
            set
            {
                this.alcoholShopCity = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string alcoholshopcommune    
        {
            get
            {
                return this.alcoholShopCommune;
            }
            set
            {
                this.alcoholShopCommune = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int alcoholshopcountryid    
        {
            get
            {
                return this.alcoholShopCountryId;
            }
            set
            {
                this.alcoholShopCountryId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int alcoholshopstateid    
        {
            get
            {
                return this.alcoholShopStateId;
            }
            set
            {
                this.alcoholShopStateId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string alcoholpermitnumber    
        {
            get
            {
                return this.alcoholPermitNumber;
            }
            set
            {
                this.alcoholPermitNumber = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string alcoholpermitauthority    
        {
            get
            {
                return this.alcoholPermitAuthority;
            }
            set
            {
                this.alcoholPermitAuthority = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string alcoholpermitinfo    
        {
            get
            {
                return this.alcoholPermitInfo;
            }
            set
            {
                this.alcoholPermitInfo = value;
                            
            }
        }
    }

    public partial class AmountStruct {
        [System.Xml.Serialization.XmlIgnore]
        public float amountvalue    
        {
            get
            {
                return this.amountValue;
            }
            set
            {
                this.amountValue = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string amountcurrencysign    
        {
            get
            {
                return this.amountCurrencySign;
            }
            set
            {
                this.amountCurrencySign = value;
                            
            }
        }
    }

    public partial class AttribStruct {
        [System.Xml.Serialization.XmlIgnore]
        public string attribname    
        {
            get
            {
                return this.attribName;
            }
            set
            {
                this.attribName = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string[] attribvalues    
        {
            get
            {
                return this.attribValues;
            }
            set
            {
                this.attribValues = value;
                            
            }
        }
    }

    public partial class BidItemStruct {
        [System.Xml.Serialization.XmlIgnore]
        public long itemid    
        {
            get
            {
                return this.itemId;
            }
            set
            {
                this.itemId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string itemtitle    
        {
            get
            {
                return this.itemTitle;
            }
            set
            {
                this.itemTitle = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string itemthumbnailurl    
        {
            get
            {
                return this.itemThumbnailUrl;
            }
            set
            {
                this.itemThumbnailUrl = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public ItemPriceStruct[] itemprice    
        {
            get
            {
                return this.itemPrice;
            }
            set
            {
                this.itemPrice = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itembidquantity    
        {
            get
            {
                return this.itemBidQuantity;
            }
            set
            {
                this.itemBidQuantity = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itemleftquantity    
        {
            get
            {
                return this.itemLeftQuantity;
            }
            set
            {
                this.itemLeftQuantity = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itemquantitytype    
        {
            get
            {
                return this.itemQuantityType;
            }
            set
            {
                this.itemQuantityType = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public long itemendtime    
        {
            get
            {
                return this.itemEndTime;
            }
            set
            {
                this.itemEndTime = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string itemendtimeleft    
        {
            get
            {
                return this.itemEndTimeLeft;
            }
            set
            {
                this.itemEndTimeLeft = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public UserInfoStruct itemseller    
        {
            get
            {
                return this.itemSeller;
            }
            set
            {
                this.itemSeller = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itembidderscounter    
        {
            get
            {
                return this.itemBiddersCounter;
            }
            set
            {
                this.itemBiddersCounter = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public UserInfoStruct itemhighestbidder    
        {
            get
            {
                return this.itemHighestBidder;
            }
            set
            {
                this.itemHighestBidder = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itemcategoryid    
        {
            get
            {
                return this.itemCategoryId;
            }
            set
            {
                this.itemCategoryId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itemviewscounter    
        {
            get
            {
                return this.itemViewsCounter;
            }
            set
            {
                this.itemViewsCounter = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string itemnote    
        {
            get
            {
                return this.itemNote;
            }
            set
            {
                this.itemNote = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itemspecialinfo    
        {
            get
            {
                return this.itemSpecialInfo;
            }
            set
            {
                this.itemSpecialInfo = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itemshopinfo    
        {
            get
            {
                return this.itemShopInfo;
            }
            set
            {
                this.itemShopInfo = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public long itemproductinfo    
        {
            get
            {
                return this.itemProductInfo;
            }
            set
            {
                this.itemProductInfo = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itempayuinfo    
        {
            get
            {
                return this.itemPayuInfo;
            }
            set
            {
                this.itemPayuInfo = value;
                            
            }
        }
    }

    public partial class BidListStruct2 {
        [System.Xml.Serialization.XmlIgnore]
        public string[] bidsarray    
        {
            get
            {
                return this.bidsArray;
            }
            set
            {
                this.bidsArray = value;
                            
            }
        }
    }

    public partial class BillingDataType {
        [System.Xml.Serialization.XmlIgnore]
        public int billingid    
        {
            get
            {
                return this.billingId;
            }
            set
            {
                this.billingId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string billingtype    
        {
            get
            {
                return this.billingType;
            }
            set
            {
                this.billingType = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string billingfixperc    
        {
            get
            {
                return this.billingFixperc;
            }
            set
            {
                this.billingFixperc = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string billingname    
        {
            get
            {
                return this.billingName;
            }
            set
            {
                this.billingName = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string billingrangefrom    
        {
            get
            {
                return this.billingRangeFrom;
            }
            set
            {
                this.billingRangeFrom = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string billingrangeto    
        {
            get
            {
                return this.billingRangeTo;
            }
            set
            {
                this.billingRangeTo = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string billingcat    
        {
            get
            {
                return this.billingCat;
            }
            set
            {
                this.billingCat = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string billingrate    
        {
            get
            {
                return this.billingRate;
            }
            set
            {
                this.billingRate = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int billingauctiontype    
        {
            get
            {
                return this.billingAuctionType;
            }
            set
            {
                this.billingAuctionType = value;
                            
            }
        }
    }

    public partial class BlackListResStruct {
        [System.Xml.Serialization.XmlIgnore]
        public long userid    
        {
            get
            {
                return this.userId;
            }
            set
            {
                this.userId = value;
                            
            }
        }
    }

    public partial class BlackListStruct {
        [System.Xml.Serialization.XmlIgnore]
        public long userid    
        {
            get
            {
                return this.userId;
            }
            set
            {
                this.userId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string userlogin    
        {
            get
            {
                return this.userLogin;
            }
            set
            {
                this.userLogin = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int userrating    
        {
            get
            {
                return this.userRating;
            }
            set
            {
                this.userRating = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int usercountry    
        {
            get
            {
                return this.userCountry;
            }
            set
            {
                this.userCountry = value;
                            
            }
        }
    }

    public partial class CancelRefundDataStruct {
        [System.Xml.Serialization.XmlIgnore]
        public long itemid    
        {
            get
            {
                return this.itemId;
            }
            set
            {
                this.itemId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int buyerid    
        {
            get
            {
                return this.buyerId;
            }
            set
            {
                this.buyerId = value;
                            
            }
        }
    }

    public partial class CancelRefundFormResultStruct {
        [System.Xml.Serialization.XmlIgnore]
        public long itemid    
        {
            get
            {
                return this.itemId;
            }
            set
            {
                this.itemId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int buyerid    
        {
            get
            {
                return this.buyerId;
            }
            set
            {
                this.buyerId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int cancelrefundresult    
        {
            get
            {
                return this.cancelRefundResult;
            }
            set
            {
                this.cancelRefundResult = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string cancelrefunderrcode    
        {
            get
            {
                return this.cancelRefundErrCode;
            }
            set
            {
                this.cancelRefundErrCode = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string cancelrefunderrmsg    
        {
            get
            {
                return this.cancelRefundErrMsg;
            }
            set
            {
                this.cancelRefundErrMsg = value;
                            
            }
        }
    }

    public partial class CancelRefundWarningResultStruct {
        [System.Xml.Serialization.XmlIgnore]
        public long itemid    
        {
            get
            {
                return this.itemId;
            }
            set
            {
                this.itemId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int buyerid    
        {
            get
            {
                return this.buyerId;
            }
            set
            {
                this.buyerId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int cancelwarningresult    
        {
            get
            {
                return this.cancelWarningResult;
            }
            set
            {
                this.cancelWarningResult = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string cancelwarningerrcode    
        {
            get
            {
                return this.cancelWarningErrCode;
            }
            set
            {
                this.cancelWarningErrCode = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string cancelwarningerrmsg    
        {
            get
            {
                return this.cancelWarningErrMsg;
            }
            set
            {
                this.cancelWarningErrMsg = value;
                            
            }
        }
    }

    public partial class CancelRefundWarningStruct {
        [System.Xml.Serialization.XmlIgnore]
        public long itemid    
        {
            get
            {
                return this.itemId;
            }
            set
            {
                this.itemId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int buyerid    
        {
            get
            {
                return this.buyerId;
            }
            set
            {
                this.buyerId = value;
                            
            }
        }
    }

    public partial class CatInfoType {
        [System.Xml.Serialization.XmlIgnore]
        public int catid    
        {
            get
            {
                return this.catId;
            }
            set
            {
                this.catId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string catname    
        {
            get
            {
                return this.catName;
            }
            set
            {
                this.catName = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int catparent    
        {
            get
            {
                return this.catParent;
            }
            set
            {
                this.catParent = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int catposition    
        {
            get
            {
                return this.catPosition;
            }
            set
            {
                this.catPosition = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int catisproductcatalogueenabled    
        {
            get
            {
                return this.catIsProductCatalogueEnabled;
            }
            set
            {
                this.catIsProductCatalogueEnabled = value;
                            
            }
        }
    }

    public partial class CategoriesStruct {
        [System.Xml.Serialization.XmlIgnore]
        public int categoryid    
        {
            get
            {
                return this.categoryId;
            }
            set
            {
                this.categoryId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string categoryname    
        {
            get
            {
                return this.categoryName;
            }
            set
            {
                this.categoryName = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int categoryparentid    
        {
            get
            {
                return this.categoryParentId;
            }
            set
            {
                this.categoryParentId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int categoryitemscount    
        {
            get
            {
                return this.categoryItemsCount;
            }
            set
            {
                this.categoryItemsCount = value;
                            
            }
        }
    }

    public partial class CategoryData {
        [System.Xml.Serialization.XmlIgnore]
        public int catid    
        {
            get
            {
                return this.catId;
            }
            set
            {
                this.catId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int catparent    
        {
            get
            {
                return this.catParent;
            }
            set
            {
                this.catParent = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int catcountry    
        {
            get
            {
                return this.catCountry;
            }
            set
            {
                this.catCountry = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int catlevel    
        {
            get
            {
                return this.catLevel;
            }
            set
            {
                this.catLevel = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int catisleaf    
        {
            get
            {
                return this.catIsLeaf;
            }
            set
            {
                this.catIsLeaf = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string catname    
        {
            get
            {
                return this.catName;
            }
            set
            {
                this.catName = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int catoptions    
        {
            get
            {
                return this.catOptions;
            }
            set
            {
                this.catOptions = value;
                            
            }
        }
    }

    public partial class ChangedItemStruct {
        [System.Xml.Serialization.XmlIgnore]
        public long itemid    
        {
            get
            {
                return this.itemId;
            }
            set
            {
                this.itemId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public FieldsValue[] itemfields    
        {
            get
            {
                return this.itemFields;
            }
            set
            {
                this.itemFields = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public ItemSurchargeStruct[] itemsurcharge    
        {
            get
            {
                return this.itemSurcharge;
            }
            set
            {
                this.itemSurcharge = value;
                            
            }
        }
    }

    public partial class CompanyExtraDataStruct {
        [System.Xml.Serialization.XmlIgnore]
        public string companytype    
        {
            get
            {
                return this.companyType;
            }
            set
            {
                this.companyType = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string companynip    
        {
            get
            {
                return this.companyNip;
            }
            set
            {
                this.companyNip = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string companyregon    
        {
            get
            {
                return this.companyRegon;
            }
            set
            {
                this.companyRegon = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string companykrs    
        {
            get
            {
                return this.companyKrs;
            }
            set
            {
                this.companyKrs = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string companyactivitysort    
        {
            get
            {
                return this.companyActivitySort;
            }
            set
            {
                this.companyActivitySort = value;
                            
            }
        }
    }

    public partial class CompanyInfoStruct {
        [System.Xml.Serialization.XmlIgnore]
        public string companyfirstname    
        {
            get
            {
                return this.companyFirstName;
            }
            set
            {
                this.companyFirstName = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string companylastname    
        {
            get
            {
                return this.companyLastName;
            }
            set
            {
                this.companyLastName = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string companyname    
        {
            get
            {
                return this.companyName;
            }
            set
            {
                this.companyName = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string companyaddress    
        {
            get
            {
                return this.companyAddress;
            }
            set
            {
                this.companyAddress = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string companypostcode    
        {
            get
            {
                return this.companyPostcode;
            }
            set
            {
                this.companyPostcode = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string companycity    
        {
            get
            {
                return this.companyCity;
            }
            set
            {
                this.companyCity = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string companynip    
        {
            get
            {
                return this.companyNip;
            }
            set
            {
                this.companyNip = value;
                            
            }
        }
    }

    public partial class CompanySecondAddressStruct {
        [System.Xml.Serialization.XmlIgnore]
        public string companyworkerfirstname    
        {
            get
            {
                return this.companyWorkerFirstName;
            }
            set
            {
                this.companyWorkerFirstName = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string companyworkerlastname    
        {
            get
            {
                return this.companyWorkerLastName;
            }
            set
            {
                this.companyWorkerLastName = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string companyaddress    
        {
            get
            {
                return this.companyAddress;
            }
            set
            {
                this.companyAddress = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string companypostcode    
        {
            get
            {
                return this.companyPostcode;
            }
            set
            {
                this.companyPostcode = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string companycity    
        {
            get
            {
                return this.companyCity;
            }
            set
            {
                this.companyCity = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int companycountryid    
        {
            get
            {
                return this.companyCountryId;
            }
            set
            {
                this.companyCountryId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int companystateid    
        {
            get
            {
                return this.companyStateId;
            }
            set
            {
                this.companyStateId = value;
                            
            }
        }
    }

    public partial class CountryInfoType {
        [System.Xml.Serialization.XmlIgnore]
        public int countryid    
        {
            get
            {
                return this.countryId;
            }
            set
            {
                this.countryId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string countryname    
        {
            get
            {
                return this.countryName;
            }
            set
            {
                this.countryName = value;
                            
            }
        }
    }

    public partial class CreatedItemTemplateStruct {
        [System.Xml.Serialization.XmlIgnore]
        public int itemtemplateid    
        {
            get
            {
                return this.itemTemplateId;
            }
            set
            {
                this.itemTemplateId = value;
                            
            }
        }
    }

    public partial class DealsStruct {
        [System.Xml.Serialization.XmlIgnore]
        public long dealid    
        {
            get
            {
                return this.dealId;
            }
            set
            {
                this.dealId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public long dealdate    
        {
            get
            {
                return this.dealDate;
            }
            set
            {
                this.dealDate = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int dealquantity    
        {
            get
            {
                return this.dealQuantity;
            }
            set
            {
                this.dealQuantity = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public float dealamountoriginal    
        {
            get
            {
                return this.dealAmountOriginal;
            }
            set
            {
                this.dealAmountOriginal = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public float dealamountdiscounted    
        {
            get
            {
                return this.dealAmountDiscounted;
            }
            set
            {
                this.dealAmountDiscounted = value;
                            
            }
        }
    }

    public partial class DiscountDataStruct {
        [System.Xml.Serialization.XmlIgnore]
        public long itemid    
        {
            get
            {
                return this.itemId;
            }
            set
            {
                this.itemId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string couponid    
        {
            get
            {
                return this.couponId;
            }
            set
            {
                this.couponId = value;
                            
            }
        }
    }

    public partial class DurationTimeInfo {
        [System.Xml.Serialization.XmlIgnore]
        public int durationoption    
        {
            get
            {
                return this.durationOption;
            }
            set
            {
                this.durationOption = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int durationvalue    
        {
            get
            {
                return this.durationValue;
            }
            set
            {
                this.durationValue = value;
                            
            }
        }
    }

    public partial class FavouritesCategoriesStruct {
        [System.Xml.Serialization.XmlIgnore]
        public int scategoryid    
        {
            get
            {
                return this.sCategoryId;
            }
            set
            {
                this.sCategoryId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int ssubscriptionstatus    
        {
            get
            {
                return this.sSubscriptionStatus;
            }
            set
            {
                this.sSubscriptionStatus = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int sposition    
        {
            get
            {
                return this.sPosition;
            }
            set
            {
                this.sPosition = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int sbuynowonly    
        {
            get
            {
                return this.sBuyNowOnly;
            }
            set
            {
                this.sBuyNowOnly = value;
                            
            }
        }
    }

    public partial class FavouritesSellersStruct {
        [System.Xml.Serialization.XmlIgnore]
        public int sfavuserid    
        {
            get
            {
                return this.sFavUserId;
            }
            set
            {
                this.sFavUserId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int ssubscriptionstatus    
        {
            get
            {
                return this.sSubscriptionStatus;
            }
            set
            {
                this.sSubscriptionStatus = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int sposition    
        {
            get
            {
                return this.sPosition;
            }
            set
            {
                this.sPosition = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int sbuynowonly    
        {
            get
            {
                return this.sBuyNowOnly;
            }
            set
            {
                this.sBuyNowOnly = value;
                            
            }
        }
    }

    public partial class FeedbackList {
        [System.Xml.Serialization.XmlIgnore]
        public int fid    
        {
            get
            {
                return this.fId;
            }
            set
            {
                this.fId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public long fitemid    
        {
            get
            {
                return this.fItemId;
            }
            set
            {
                this.fItemId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int ffromid    
        {
            get
            {
                return this.fFromId;
            }
            set
            {
                this.fFromId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int ftoid    
        {
            get
            {
                return this.fToId;
            }
            set
            {
                this.fToId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public long fdate    
        {
            get
            {
                return this.fDate;
            }
            set
            {
                this.fDate = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string ftype    
        {
            get
            {
                return this.fType;
            }
            set
            {
                this.fType = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string fdesc    
        {
            get
            {
                return this.fDesc;
            }
            set
            {
                this.fDesc = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public long fcorrectdate    
        {
            get
            {
                return this.fCorrectDate;
            }
            set
            {
                this.fCorrectDate = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string fcorrecttext    
        {
            get
            {
                return this.fCorrectText;
            }
            set
            {
                this.fCorrectText = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string freceivertype    
        {
            get
            {
                return this.fReceiverType;
            }
            set
            {
                this.fReceiverType = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string fuserlogin    
        {
            get
            {
                return this.fUserLogin;
            }
            set
            {
                this.fUserLogin = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string fuserrating    
        {
            get
            {
                return this.fUserRating;
            }
            set
            {
                this.fUserRating = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string fusercountry    
        {
            get
            {
                return this.fUserCountry;
            }
            set
            {
                this.fUserCountry = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int fuserblocked    
        {
            get
            {
                return this.fUserBlocked;
            }
            set
            {
                this.fUserBlocked = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int fusersseller    
        {
            get
            {
                return this.fUserSseller;
            }
            set
            {
                this.fUserSseller = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public long fcancelled    
        {
            get
            {
                return this.fCancelled;
            }
            set
            {
                this.fCancelled = value;
                            
            }
        }
    }

    public partial class FeedbackManyStruct {
        [System.Xml.Serialization.XmlIgnore]
        public long feitemid    
        {
            get
            {
                return this.feItemId;
            }
            set
            {
                this.feItemId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int feusecommenttemplate    
        {
            get
            {
                return this.feUseCommentTemplate;
            }
            set
            {
                this.feUseCommentTemplate = value;
                this.feUseCommentTemplateSpecified = true;            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int fetouserid    
        {
            get
            {
                return this.feToUserId;
            }
            set
            {
                this.feToUserId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string fecomment    
        {
            get
            {
                return this.feComment;
            }
            set
            {
                this.feComment = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string fecommenttype    
        {
            get
            {
                return this.feCommentType;
            }
            set
            {
                this.feCommentType = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int feop    
        {
            get
            {
                return this.feOp;
            }
            set
            {
                this.feOp = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public SellRatingEstimationStruct[] ferating    
        {
            get
            {
                return this.feRating;
            }
            set
            {
                this.feRating = value;
                            
            }
        }
    }

    public partial class FeedbackResultStruct {
        [System.Xml.Serialization.XmlIgnore]
        public long feitemid    
        {
            get
            {
                return this.feItemId;
            }
            set
            {
                this.feItemId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int feid    
        {
            get
            {
                return this.feId;
            }
            set
            {
                this.feId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string fefaultcode    
        {
            get
            {
                return this.feFaultCode;
            }
            set
            {
                this.feFaultCode = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string fefaultdesc    
        {
            get
            {
                return this.feFaultDesc;
            }
            set
            {
                this.feFaultDesc = value;
                            
            }
        }
    }

    public partial class FieldsValue {
        [System.Xml.Serialization.XmlIgnore]
        public string fvaluestring    
        {
            get
            {
                return this.fvalueString;
            }
            set
            {
                this.fvalueString = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int fvalueint    
        {
            get
            {
                return this.fvalueInt;
            }
            set
            {
                this.fvalueInt = value;
                this.fvalueIntSpecified = true;            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public float fvaluefloat    
        {
            get
            {
                return this.fvalueFloat;
            }
            set
            {
                this.fvalueFloat = value;
                this.fvalueFloatSpecified = true;            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public byte[] fvalueimage    
        {
            get
            {
                return this.fvalueImage;
            }
            set
            {
                this.fvalueImage = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public float fvaluedatetime    
        {
            get
            {
                return this.fvalueDatetime;
            }
            set
            {
                this.fvalueDatetime = value;
                this.fvalueDatetimeSpecified = true;            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string fvaluedate    
        {
            get
            {
                return this.fvalueDate;
            }
            set
            {
                this.fvalueDate = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public RangeIntValueStruct fvaluerangeint    
        {
            get
            {
                return this.fvalueRangeInt;
            }
            set
            {
                this.fvalueRangeInt = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public RangeFloatValueStruct fvaluerangefloat    
        {
            get
            {
                return this.fvalueRangeFloat;
            }
            set
            {
                this.fvalueRangeFloat = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public RangeDateValueStruct fvaluerangedate    
        {
            get
            {
                return this.fvalueRangeDate;
            }
            set
            {
                this.fvalueRangeDate = value;
                            
            }
        }
    }

    public partial class FilledPostBuyFormsStruct {
        [System.Xml.Serialization.XmlIgnore]
        public long[] transactionids    
        {
            get
            {
                return this.transactionIds;
            }
            set
            {
                this.transactionIds = value;
                            
            }
        }
    }

    public partial class FilterOptionsType {
        [System.Xml.Serialization.XmlIgnore]
        public string filterid    
        {
            get
            {
                return this.filterId;
            }
            set
            {
                this.filterId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string[] filtervalueid    
        {
            get
            {
                return this.filterValueId;
            }
            set
            {
                this.filterValueId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public RangeValueType filtervaluerange    
        {
            get
            {
                return this.filterValueRange;
            }
            set
            {
                this.filterValueRange = value;
                            
            }
        }
    }

    public partial class FilterPriceStruct {
        [System.Xml.Serialization.XmlIgnore]
        public float filterpricefrom    
        {
            get
            {
                return this.filterPriceFrom;
            }
            set
            {
                this.filterPriceFrom = value;
                this.filterPriceFromSpecified = true;            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public float filterpriceto    
        {
            get
            {
                return this.filterPriceTo;
            }
            set
            {
                this.filterPriceTo = value;
                this.filterPriceToSpecified = true;            
            }
        }
    }

    public partial class FilterRelationType {
        [System.Xml.Serialization.XmlIgnore]
        public string[] relationand    
        {
            get
            {
                return this.relationAnd;
            }
            set
            {
                this.relationAnd = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string[] relationor    
        {
            get
            {
                return this.relationOr;
            }
            set
            {
                this.relationOr = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string[] relationexclude    
        {
            get
            {
                return this.relationExclude;
            }
            set
            {
                this.relationExclude = value;
                            
            }
        }
    }

    public partial class FilterValueType {
        [System.Xml.Serialization.XmlIgnore]
        public string filtervalueid    
        {
            get
            {
                return this.filterValueId;
            }
            set
            {
                this.filterValueId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string filtervaluename    
        {
            get
            {
                return this.filterValueName;
            }
            set
            {
                this.filterValueName = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int filtervaluecount    
        {
            get
            {
                return this.filterValueCount;
            }
            set
            {
                this.filterValueCount = value;
                this.filterValueCountSpecified = true;            
            }
        }
    }

    public partial class FiltersListType {
        [System.Xml.Serialization.XmlIgnore]
        public string filterid    
        {
            get
            {
                return this.filterId;
            }
            set
            {
                this.filterId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string filtername    
        {
            get
            {
                return this.filterName;
            }
            set
            {
                this.filterName = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string filtertype    
        {
            get
            {
                return this.filterType;
            }
            set
            {
                this.filterType = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string filtercontroltype    
        {
            get
            {
                return this.filterControlType;
            }
            set
            {
                this.filterControlType = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string filterdatatype    
        {
            get
            {
                return this.filterDataType;
            }
            set
            {
                this.filterDataType = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public bool filterisrange    
        {
            get
            {
                return this.filterIsRange;
            }
            set
            {
                this.filterIsRange = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int filterarraysize    
        {
            get
            {
                return this.filterArraySize;
            }
            set
            {
                this.filterArraySize = value;
                this.filterArraySizeSpecified = true;            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public FilterValueType[] filtervalues    
        {
            get
            {
                return this.filterValues;
            }
            set
            {
                this.filterValues = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public FilterRelationType filterrelations    
        {
            get
            {
                return this.filterRelations;
            }
            set
            {
                this.filterRelations = value;
                            
            }
        }
    }

    public partial class FinishFailureStruct {
        [System.Xml.Serialization.XmlIgnore]
        public long finishitemid    
        {
            get
            {
                return this.finishItemId;
            }
            set
            {
                this.finishItemId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string finisherrorcode    
        {
            get
            {
                return this.finishErrorCode;
            }
            set
            {
                this.finishErrorCode = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string finisherrormessage    
        {
            get
            {
                return this.finishErrorMessage;
            }
            set
            {
                this.finishErrorMessage = value;
                            
            }
        }
    }

    public partial class FinishItemsStruct {
        [System.Xml.Serialization.XmlIgnore]
        public long finishitemid    
        {
            get
            {
                return this.finishItemId;
            }
            set
            {
                this.finishItemId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int finishcancelallbids    
        {
            get
            {
                return this.finishCancelAllBids;
            }
            set
            {
                this.finishCancelAllBids = value;
                this.finishCancelAllBidsSpecified = true;            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string finishcancelreason    
        {
            get
            {
                return this.finishCancelReason;
            }
            set
            {
                this.finishCancelReason = value;
                            
            }
        }
    }

    public partial class FulfillmentTimeStruct {
        [System.Xml.Serialization.XmlIgnore]
        public int fulfillmenttimefrom    
        {
            get
            {
                return this.fulfillmentTimeFrom;
            }
            set
            {
                this.fulfillmentTimeFrom = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int fulfillmenttimeto    
        {
            get
            {
                return this.fulfillmentTimeTo;
            }
            set
            {
                this.fulfillmentTimeTo = value;
                            
            }
        }
    }

    public partial class FutureFilterOptionsStruct {
        [System.Xml.Serialization.XmlIgnore]
        public int filterformat    
        {
            get
            {
                return this.filterFormat;
            }
            set
            {
                this.filterFormat = value;
                this.filterFormatSpecified = true;            
            }
        }
    }

    public partial class FutureItemStruct {
        [System.Xml.Serialization.XmlIgnore]
        public long itemid    
        {
            get
            {
                return this.itemId;
            }
            set
            {
                this.itemId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string itemtitle    
        {
            get
            {
                return this.itemTitle;
            }
            set
            {
                this.itemTitle = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string itemthumbnailurl    
        {
            get
            {
                return this.itemThumbnailUrl;
            }
            set
            {
                this.itemThumbnailUrl = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public ItemPriceStruct[] itemprice    
        {
            get
            {
                return this.itemPrice;
            }
            set
            {
                this.itemPrice = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itemstartquantity    
        {
            get
            {
                return this.itemStartQuantity;
            }
            set
            {
                this.itemStartQuantity = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itemquantitytype    
        {
            get
            {
                return this.itemQuantityType;
            }
            set
            {
                this.itemQuantityType = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public long itemstarttime    
        {
            get
            {
                return this.itemStartTime;
            }
            set
            {
                this.itemStartTime = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itemcategoryid    
        {
            get
            {
                return this.itemCategoryId;
            }
            set
            {
                this.itemCategoryId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string itemnote    
        {
            get
            {
                return this.itemNote;
            }
            set
            {
                this.itemNote = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itemspecialinfo    
        {
            get
            {
                return this.itemSpecialInfo;
            }
            set
            {
                this.itemSpecialInfo = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itemshopinfo    
        {
            get
            {
                return this.itemShopInfo;
            }
            set
            {
                this.itemShopInfo = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public long itemproductinfo    
        {
            get
            {
                return this.itemProductInfo;
            }
            set
            {
                this.itemProductInfo = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itempayuinfo    
        {
            get
            {
                return this.itemPayuInfo;
            }
            set
            {
                this.itemPayuInfo = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itemstatus    
        {
            get
            {
                return this.itemStatus;
            }
            set
            {
                this.itemStatus = value;
                            
            }
        }
    }

    public partial class InfoCatList {
        [System.Xml.Serialization.XmlIgnore]
        public long catid    
        {
            get
            {
                return this.catId;
            }
            set
            {
                this.catId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string catname    
        {
            get
            {
                return this.catName;
            }
            set
            {
                this.catName = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public long catitemscount    
        {
            get
            {
                return this.catItemsCount;
            }
            set
            {
                this.catItemsCount = value;
                            
            }
        }
    }

    public partial class InvoiceDataStruct {
        [System.Xml.Serialization.XmlIgnore]
        public string companyname    
        {
            get
            {
                return this.companyName;
            }
            set
            {
                this.companyName = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string companynip    
        {
            get
            {
                return this.companyNip;
            }
            set
            {
                this.companyNip = value;
                            
            }
        }
    }

    public partial class InvoiceInfoStruct {
        [System.Xml.Serialization.XmlIgnore]
        public int invoiceaddresstype    
        {
            get
            {
                return this.invoiceAddressType;
            }
            set
            {
                this.invoiceAddressType = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public AddressUserDataStruct invoiceaddressdata    
        {
            get
            {
                return this.invoiceAddressData;
            }
            set
            {
                this.invoiceAddressData = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string invoicenip    
        {
            get
            {
                return this.invoiceNip;
            }
            set
            {
                this.invoiceNip = value;
                            
            }
        }
    }

    public partial class ItemBilling {
        [System.Xml.Serialization.XmlIgnore]
        public string biname    
        {
            get
            {
                return this.biName;
            }
            set
            {
                this.biName = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string bivalue    
        {
            get
            {
                return this.biValue;
            }
            set
            {
                this.biValue = value;
                            
            }
        }
    }

    public partial class ItemCatList {
        [System.Xml.Serialization.XmlIgnore]
        public int catlevel    
        {
            get
            {
                return this.catLevel;
            }
            set
            {
                this.catLevel = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public long catid    
        {
            get
            {
                return this.catId;
            }
            set
            {
                this.catId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string catname    
        {
            get
            {
                return this.catName;
            }
            set
            {
                this.catName = value;
                            
            }
        }
    }

    public partial class ItemDescriptionStruct {
        [System.Xml.Serialization.XmlIgnore]
        public string descriptionresult    
        {
            get
            {
                return this.descriptionResult;
            }
            set
            {
                this.descriptionResult = value;
                            
            }
        }
    }

    public partial class ItemDiscountCouponStruct {
        [System.Xml.Serialization.XmlIgnore]
        public PriceStruct itempriceoriginal    
        {
            get
            {
                return this.itemPriceOriginal;
            }
            set
            {
                this.itemPriceOriginal = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public PriceStruct itempricediscounted    
        {
            get
            {
                return this.itemPriceDiscounted;
            }
            set
            {
                this.itemPriceDiscounted = value;
                            
            }
        }
    }

    public partial class ItemGetImage {
        [System.Xml.Serialization.XmlIgnore]
        public long itid    
        {
            get
            {
                return this.itId;
            }
            set
            {
                this.itId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public long itsellerid    
        {
            get
            {
                return this.itSellerId;
            }
            set
            {
                this.itSellerId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itfotocount    
        {
            get
            {
                return this.itFotoCount;
            }
            set
            {
                this.itFotoCount = value;
                            
            }
        }
    }

    public partial class ItemImageList {
        [System.Xml.Serialization.XmlIgnore]
        public int imagetype    
        {
            get
            {
                return this.imageType;
            }
            set
            {
                this.imageType = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string imageurl    
        {
            get
            {
                return this.imageUrl;
            }
            set
            {
                this.imageUrl = value;
                            
            }
        }
    }

    public partial class ItemImagesStruct {
        [System.Xml.Serialization.XmlIgnore]
        public long itemid    
        {
            get
            {
                return this.itemId;
            }
            set
            {
                this.itemId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public ItemImageList[] itemimages    
        {
            get
            {
                return this.itemImages;
            }
            set
            {
                this.itemImages = value;
                            
            }
        }
    }

    public partial class ItemInfo {
        [System.Xml.Serialization.XmlIgnore]
        public long itid    
        {
            get
            {
                return this.itId;
            }
            set
            {
                this.itId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itcountry    
        {
            get
            {
                return this.itCountry;
            }
            set
            {
                this.itCountry = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string itname    
        {
            get
            {
                return this.itName;
            }
            set
            {
                this.itName = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public float itprice    
        {
            get
            {
                return this.itPrice;
            }
            set
            {
                this.itPrice = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itbidcount    
        {
            get
            {
                return this.itBidCount;
            }
            set
            {
                this.itBidCount = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public long itendingtime    
        {
            get
            {
                return this.itEndingTime;
            }
            set
            {
                this.itEndingTime = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public long itsellerid    
        {
            get
            {
                return this.itSellerId;
            }
            set
            {
                this.itSellerId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string itsellerlogin    
        {
            get
            {
                return this.itSellerLogin;
            }
            set
            {
                this.itSellerLogin = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itsellerrating    
        {
            get
            {
                return this.itSellerRating;
            }
            set
            {
                this.itSellerRating = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public long itstartingtime    
        {
            get
            {
                return this.itStartingTime;
            }
            set
            {
                this.itStartingTime = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public float itstartingprice    
        {
            get
            {
                return this.itStartingPrice;
            }
            set
            {
                this.itStartingPrice = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itquantity    
        {
            get
            {
                return this.itQuantity;
            }
            set
            {
                this.itQuantity = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itfotocount    
        {
            get
            {
                return this.itFotoCount;
            }
            set
            {
                this.itFotoCount = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public float itreserveprice    
        {
            get
            {
                return this.itReservePrice;
            }
            set
            {
                this.itReservePrice = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string itlocation    
        {
            get
            {
                return this.itLocation;
            }
            set
            {
                this.itLocation = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public float itbuynowprice    
        {
            get
            {
                return this.itBuyNowPrice;
            }
            set
            {
                this.itBuyNowPrice = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itbuynowactive    
        {
            get
            {
                return this.itBuyNowActive;
            }
            set
            {
                this.itBuyNowActive = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int ithighbidder    
        {
            get
            {
                return this.itHighBidder;
            }
            set
            {
                this.itHighBidder = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string ithighbidderlogin    
        {
            get
            {
                return this.itHighBidderLogin;
            }
            set
            {
                this.itHighBidderLogin = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string itdescription    
        {
            get
            {
                return this.itDescription;
            }
            set
            {
                this.itDescription = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itoptions    
        {
            get
            {
                return this.itOptions;
            }
            set
            {
                this.itOptions = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itstate    
        {
            get
            {
                return this.itState;
            }
            set
            {
                this.itState = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itiseco    
        {
            get
            {
                return this.itIsEco;
            }
            set
            {
                this.itIsEco = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public long ithitcount    
        {
            get
            {
                return this.itHitCount;
            }
            set
            {
                this.itHitCount = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string itpostcode    
        {
            get
            {
                return this.itPostcode;
            }
            set
            {
                this.itPostcode = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itvatinvoice    
        {
            get
            {
                return this.itVatInvoice;
            }
            set
            {
                this.itVatInvoice = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string itbankaccount1    
        {
            get
            {
                return this.itBankAccount1;
            }
            set
            {
                this.itBankAccount1 = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string itbankaccount2    
        {
            get
            {
                return this.itBankAccount2;
            }
            set
            {
                this.itBankAccount2 = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itstartingquantity    
        {
            get
            {
                return this.itStartingQuantity;
            }
            set
            {
                this.itStartingQuantity = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itisforguests    
        {
            get
            {
                return this.itIsForGuests;
            }
            set
            {
                this.itIsForGuests = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int ithasproduct    
        {
            get
            {
                return this.itHasProduct;
            }
            set
            {
                this.itHasProduct = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itorderfulfillmenttime    
        {
            get
            {
                return this.itOrderFulfillmentTime;
            }
            set
            {
                this.itOrderFulfillmentTime = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itendinginfo    
        {
            get
            {
                return this.itEndingInfo;
            }
            set
            {
                this.itEndingInfo = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itisallegrostandard    
        {
            get
            {
                return this.itIsAllegroStandard;
            }
            set
            {
                this.itIsAllegroStandard = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itisnewused    
        {
            get
            {
                return this.itIsNewUsed;
            }
            set
            {
                this.itIsNewUsed = value;
                            
            }
        }
    }

    public partial class ItemInfoExt {
        [System.Xml.Serialization.XmlIgnore]
        public long itid    
        {
            get
            {
                return this.itId;
            }
            set
            {
                this.itId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itcountry    
        {
            get
            {
                return this.itCountry;
            }
            set
            {
                this.itCountry = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string itname    
        {
            get
            {
                return this.itName;
            }
            set
            {
                this.itName = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public float itprice    
        {
            get
            {
                return this.itPrice;
            }
            set
            {
                this.itPrice = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itbidcount    
        {
            get
            {
                return this.itBidCount;
            }
            set
            {
                this.itBidCount = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public long itendingtime    
        {
            get
            {
                return this.itEndingTime;
            }
            set
            {
                this.itEndingTime = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public long itsellerid    
        {
            get
            {
                return this.itSellerId;
            }
            set
            {
                this.itSellerId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string itsellerlogin    
        {
            get
            {
                return this.itSellerLogin;
            }
            set
            {
                this.itSellerLogin = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itsellerrating    
        {
            get
            {
                return this.itSellerRating;
            }
            set
            {
                this.itSellerRating = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public long itstartingtime    
        {
            get
            {
                return this.itStartingTime;
            }
            set
            {
                this.itStartingTime = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public float itstartingprice    
        {
            get
            {
                return this.itStartingPrice;
            }
            set
            {
                this.itStartingPrice = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itquantity    
        {
            get
            {
                return this.itQuantity;
            }
            set
            {
                this.itQuantity = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itfotocount    
        {
            get
            {
                return this.itFotoCount;
            }
            set
            {
                this.itFotoCount = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public float itreserveprice    
        {
            get
            {
                return this.itReservePrice;
            }
            set
            {
                this.itReservePrice = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string itlocation    
        {
            get
            {
                return this.itLocation;
            }
            set
            {
                this.itLocation = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public float itbuynowprice    
        {
            get
            {
                return this.itBuyNowPrice;
            }
            set
            {
                this.itBuyNowPrice = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itbuynowactive    
        {
            get
            {
                return this.itBuyNowActive;
            }
            set
            {
                this.itBuyNowActive = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int ithighbidder    
        {
            get
            {
                return this.itHighBidder;
            }
            set
            {
                this.itHighBidder = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string ithighbidderlogin    
        {
            get
            {
                return this.itHighBidderLogin;
            }
            set
            {
                this.itHighBidderLogin = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string itdescription    
        {
            get
            {
                return this.itDescription;
            }
            set
            {
                this.itDescription = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itoptions    
        {
            get
            {
                return this.itOptions;
            }
            set
            {
                this.itOptions = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itstate    
        {
            get
            {
                return this.itState;
            }
            set
            {
                this.itState = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public float itwiretransfer    
        {
            get
            {
                return this.itWireTransfer;
            }
            set
            {
                this.itWireTransfer = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public float itpostdelivery    
        {
            get
            {
                return this.itPostDelivery;
            }
            set
            {
                this.itPostDelivery = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string itpostinfo    
        {
            get
            {
                return this.itPostInfo;
            }
            set
            {
                this.itPostInfo = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itquantitytype    
        {
            get
            {
                return this.itQuantityType;
            }
            set
            {
                this.itQuantityType = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itiseco    
        {
            get
            {
                return this.itIsEco;
            }
            set
            {
                this.itIsEco = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public long ithitcount    
        {
            get
            {
                return this.itHitCount;
            }
            set
            {
                this.itHitCount = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string itpostcode    
        {
            get
            {
                return this.itPostcode;
            }
            set
            {
                this.itPostcode = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itvatinvoice    
        {
            get
            {
                return this.itVatInvoice;
            }
            set
            {
                this.itVatInvoice = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string itbankaccount1    
        {
            get
            {
                return this.itBankAccount1;
            }
            set
            {
                this.itBankAccount1 = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string itbankaccount2    
        {
            get
            {
                return this.itBankAccount2;
            }
            set
            {
                this.itBankAccount2 = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itstartingquantity    
        {
            get
            {
                return this.itStartingQuantity;
            }
            set
            {
                this.itStartingQuantity = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itisforguests    
        {
            get
            {
                return this.itIsForGuests;
            }
            set
            {
                this.itIsForGuests = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int ithasproduct    
        {
            get
            {
                return this.itHasProduct;
            }
            set
            {
                this.itHasProduct = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itorderfulfillmenttime    
        {
            get
            {
                return this.itOrderFulfillmentTime;
            }
            set
            {
                this.itOrderFulfillmentTime = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itendinginfo    
        {
            get
            {
                return this.itEndingInfo;
            }
            set
            {
                this.itEndingInfo = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itisallegrostandard    
        {
            get
            {
                return this.itIsAllegroStandard;
            }
            set
            {
                this.itIsAllegroStandard = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itisnewused    
        {
            get
            {
                return this.itIsNewUsed;
            }
            set
            {
                this.itIsNewUsed = value;
                            
            }
        }
    }

    public partial class ItemInfoStruct {
        [System.Xml.Serialization.XmlIgnore]
        public ItemInfo iteminfo    
        {
            get
            {
                return this.itemInfo;
            }
            set
            {
                this.itemInfo = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public ItemCatList[] itemcats    
        {
            get
            {
                return this.itemCats;
            }
            set
            {
                this.itemCats = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public ItemImageList[] itemimages    
        {
            get
            {
                return this.itemImages;
            }
            set
            {
                this.itemImages = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public AttribStruct[] itemattribs    
        {
            get
            {
                return this.itemAttribs;
            }
            set
            {
                this.itemAttribs = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public PostageStruct[] itempostageoptions    
        {
            get
            {
                return this.itemPostageOptions;
            }
            set
            {
                this.itemPostageOptions = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public ItemPaymentOptions itempaymentoptions    
        {
            get
            {
                return this.itemPaymentOptions;
            }
            set
            {
                this.itemPaymentOptions = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public CompanyInfoStruct itemcompanyinfo    
        {
            get
            {
                return this.itemCompanyInfo;
            }
            set
            {
                this.itemCompanyInfo = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public ProductStruct itemproductinfo    
        {
            get
            {
                return this.itemProductInfo;
            }
            set
            {
                this.itemProductInfo = value;
                            
            }
        }
    }

    public partial class ItemPaymentOptions {
        [System.Xml.Serialization.XmlIgnore]
        public int payoptiontransfer    
        {
            get
            {
                return this.payOptionTransfer;
            }
            set
            {
                this.payOptionTransfer = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int payoptionondelivery    
        {
            get
            {
                return this.payOptionOnDelivery;
            }
            set
            {
                this.payOptionOnDelivery = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int payoptionallegropay    
        {
            get
            {
                return this.payOptionAllegroPay;
            }
            set
            {
                this.payOptionAllegroPay = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int payoptionseedesc    
        {
            get
            {
                return this.payOptionSeeDesc;
            }
            set
            {
                this.payOptionSeeDesc = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int payoptionpayu    
        {
            get
            {
                return this.payOptionPayu;
            }
            set
            {
                this.payOptionPayu = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int payoptionescrow    
        {
            get
            {
                return this.payOptionEscrow;
            }
            set
            {
                this.payOptionEscrow = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int payoptionqiwi    
        {
            get
            {
                return this.payOptionQiwi;
            }
            set
            {
                this.payOptionQiwi = value;
                            
            }
        }
    }

    public partial class ItemPostBuyDataStruct {
        [System.Xml.Serialization.XmlIgnore]
        public long itemid    
        {
            get
            {
                return this.itemId;
            }
            set
            {
                this.itemId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public UserPostBuyDataStruct[] userspostbuydata    
        {
            get
            {
                return this.usersPostBuyData;
            }
            set
            {
                this.usersPostBuyData = value;
                            
            }
        }
    }

    public partial class ItemPriceStruct {
        [System.Xml.Serialization.XmlIgnore]
        public int pricetype    
        {
            get
            {
                return this.priceType;
            }
            set
            {
                this.priceType = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public float pricevalue    
        {
            get
            {
                return this.priceValue;
            }
            set
            {
                this.priceValue = value;
                            
            }
        }
    }

    public partial class ItemReminderStruct {
        [System.Xml.Serialization.XmlIgnore]
        public int remindertype    
        {
            get
            {
                return this.reminderType;
            }
            set
            {
                this.reminderType = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int remindertime    
        {
            get
            {
                return this.reminderTime;
            }
            set
            {
                this.reminderTime = value;
                            
            }
        }
    }

    public partial class ItemRemoveWatchStruct {
        [System.Xml.Serialization.XmlIgnore]
        public long itemid    
        {
            get
            {
                return this.itemId;
            }
            set
            {
                this.itemId = value;
                            
            }
        }
    }

    public partial class ItemSurchargeStruct {
        [System.Xml.Serialization.XmlIgnore]
        public string surchargedescription    
        {
            get
            {
                return this.surchargeDescription;
            }
            set
            {
                this.surchargeDescription = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public AmountStruct surchargeamount    
        {
            get
            {
                return this.surchargeAmount;
            }
            set
            {
                this.surchargeAmount = value;
                            
            }
        }
    }

    public partial class ItemTemplateCreateStruct {
        [System.Xml.Serialization.XmlIgnore]
        public int itemtemplateoption    
        {
            get
            {
                return this.itemTemplateOption;
            }
            set
            {
                this.itemTemplateOption = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string itemtemplatename    
        {
            get
            {
                return this.itemTemplateName;
            }
            set
            {
                this.itemTemplateName = value;
                            
            }
        }
    }

    public partial class ItemTemplateListStruct {
        [System.Xml.Serialization.XmlIgnore]
        public int itemtemplateid    
        {
            get
            {
                return this.itemTemplateId;
            }
            set
            {
                this.itemTemplateId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string itemtemplatename    
        {
            get
            {
                return this.itemTemplateName;
            }
            set
            {
                this.itemTemplateName = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public FieldsValue[] itemtemplatefields    
        {
            get
            {
                return this.itemTemplateFields;
            }
            set
            {
                this.itemTemplateFields = value;
                            
            }
        }
    }

    public partial class ItemTemplatesStruct {
        [System.Xml.Serialization.XmlIgnore]
        public ItemTemplateListStruct[] itemtemplatelist    
        {
            get
            {
                return this.itemTemplateList;
            }
            set
            {
                this.itemTemplateList = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int[] itemtemplateincorrectids    
        {
            get
            {
                return this.itemTemplateIncorrectIds;
            }
            set
            {
                this.itemTemplateIncorrectIds = value;
                            
            }
        }
    }

    public partial class ItemsNotAddedStruct {
        [System.Xml.Serialization.XmlIgnore]
        public long itemid    
        {
            get
            {
                return this.itemId;
            }
            set
            {
                this.itemId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string itemerrorcode    
        {
            get
            {
                return this.itemErrorCode;
            }
            set
            {
                this.itemErrorCode = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string itemerrordescription    
        {
            get
            {
                return this.itemErrorDescription;
            }
            set
            {
                this.itemErrorDescription = value;
                            
            }
        }
    }

    public partial class MessageToBuyerStruct {
        [System.Xml.Serialization.XmlIgnore]
        public int messagesellerid    
        {
            get
            {
                return this.messageSellerId;
            }
            set
            {
                this.messageSellerId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string messagecontent    
        {
            get
            {
                return this.messageContent;
            }
            set
            {
                this.messageContent = value;
                            
            }
        }
    }

    public partial class MyAccountStruct2 {
        [System.Xml.Serialization.XmlIgnore]
        public string[] myaccountarray    
        {
            get
            {
                return this.myAccountArray;
            }
            set
            {
                this.myAccountArray = value;
                            
            }
        }
    }

    public partial class MyContactList {
        [System.Xml.Serialization.XmlIgnore]
        public int contactuserid    
        {
            get
            {
                return this.contactUserId;
            }
            set
            {
                this.contactUserId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string contactnick    
        {
            get
            {
                return this.contactNick;
            }
            set
            {
                this.contactNick = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string contactfirstname    
        {
            get
            {
                return this.contactFirstName;
            }
            set
            {
                this.contactFirstName = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string contactlastname    
        {
            get
            {
                return this.contactLastName;
            }
            set
            {
                this.contactLastName = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string contactcompany    
        {
            get
            {
                return this.contactCompany;
            }
            set
            {
                this.contactCompany = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string contactemail    
        {
            get
            {
                return this.contactEmail;
            }
            set
            {
                this.contactEmail = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string contactstreet    
        {
            get
            {
                return this.contactStreet;
            }
            set
            {
                this.contactStreet = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string contactpostcode    
        {
            get
            {
                return this.contactPostcode;
            }
            set
            {
                this.contactPostcode = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string contactcity    
        {
            get
            {
                return this.contactCity;
            }
            set
            {
                this.contactCity = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string contactcountry    
        {
            get
            {
                return this.contactCountry;
            }
            set
            {
                this.contactCountry = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string contactphone    
        {
            get
            {
                return this.contactPhone;
            }
            set
            {
                this.contactPhone = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string contactphone2    
        {
            get
            {
                return this.contactPhone2;
            }
            set
            {
                this.contactPhone2 = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string contactrating    
        {
            get
            {
                return this.contactRating;
            }
            set
            {
                this.contactRating = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string contactblocked    
        {
            get
            {
                return this.contactBlocked;
            }
            set
            {
                this.contactBlocked = value;
                            
            }
        }
    }

    public partial class MyFeedbackListStruct2 {
        [System.Xml.Serialization.XmlIgnore]
        public string[] feedbackarray    
        {
            get
            {
                return this.feedbackArray;
            }
            set
            {
                this.feedbackArray = value;
                            
            }
        }
    }

    public partial class NewPostBuyFormCommonStruct {
        [System.Xml.Serialization.XmlIgnore]
        public string paymentmethodid    
        {
            get
            {
                return this.paymentMethodId;
            }
            set
            {
                this.paymentMethodId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int shipmentaddresstype    
        {
            get
            {
                return this.shipmentAddressType;
            }
            set
            {
                this.shipmentAddressType = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public AddressUserDataStruct shipmentaddressdata    
        {
            get
            {
                return this.shipmentAddressData;
            }
            set
            {
                this.shipmentAddressData = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string contactphone    
        {
            get
            {
                return this.contactPhone;
            }
            set
            {
                this.contactPhone = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int invoiceoption    
        {
            get
            {
                return this.invoiceOption;
            }
            set
            {
                this.invoiceOption = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public InvoiceInfoStruct invoiceinfo    
        {
            get
            {
                return this.invoiceInfo;
            }
            set
            {
                this.invoiceInfo = value;
                            
            }
        }
    }

    public partial class NewPostBuyFormSellerStruct {
        [System.Xml.Serialization.XmlIgnore]
        public int sellerid    
        {
            get
            {
                return this.sellerId;
            }
            set
            {
                this.sellerId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public long[] selleritemids    
        {
            get
            {
                return this.sellerItemIds;
            }
            set
            {
                this.sellerItemIds = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int sellershipmentid    
        {
            get
            {
                return this.sellerShipmentId;
            }
            set
            {
                this.sellerShipmentId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public float sellershipmentamount    
        {
            get
            {
                return this.sellerShipmentAmount;
            }
            set
            {
                this.sellerShipmentAmount = value;
                this.sellerShipmentAmountSpecified = true;            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string sellermessageto    
        {
            get
            {
                return this.sellerMessageTo;
            }
            set
            {
                this.sellerMessageTo = value;
                            
            }
        }
    }

    public partial class NotSoldFilterOptionsStruct {
        [System.Xml.Serialization.XmlIgnore]
        public int filterformat    
        {
            get
            {
                return this.filterFormat;
            }
            set
            {
                this.filterFormat = value;
                this.filterFormatSpecified = true;            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int filterfromend    
        {
            get
            {
                return this.filterFromEnd;
            }
            set
            {
                this.filterFromEnd = value;
                this.filterFromEndSpecified = true;            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int filterautolisting    
        {
            get
            {
                return this.filterAutoListing;
            }
            set
            {
                this.filterAutoListing = value;
                this.filterAutoListingSpecified = true;            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public FilterPriceStruct filterprice    
        {
            get
            {
                return this.filterPrice;
            }
            set
            {
                this.filterPrice = value;
                            
            }
        }
    }

    public partial class NotSoldItemStruct {
        [System.Xml.Serialization.XmlIgnore]
        public long itemid    
        {
            get
            {
                return this.itemId;
            }
            set
            {
                this.itemId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string itemtitle    
        {
            get
            {
                return this.itemTitle;
            }
            set
            {
                this.itemTitle = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string itemthumbnailurl    
        {
            get
            {
                return this.itemThumbnailUrl;
            }
            set
            {
                this.itemThumbnailUrl = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public ItemPriceStruct[] itemprice    
        {
            get
            {
                return this.itemPrice;
            }
            set
            {
                this.itemPrice = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itemstartquantity    
        {
            get
            {
                return this.itemStartQuantity;
            }
            set
            {
                this.itemStartQuantity = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itemquantitytype    
        {
            get
            {
                return this.itemQuantityType;
            }
            set
            {
                this.itemQuantityType = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public long itemstarttime    
        {
            get
            {
                return this.itemStartTime;
            }
            set
            {
                this.itemStartTime = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public long itemendtime    
        {
            get
            {
                return this.itemEndTime;
            }
            set
            {
                this.itemEndTime = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itembidderscounter    
        {
            get
            {
                return this.itemBiddersCounter;
            }
            set
            {
                this.itemBiddersCounter = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public UserInfoStruct itemhighestbidder    
        {
            get
            {
                return this.itemHighestBidder;
            }
            set
            {
                this.itemHighestBidder = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itemcategoryid    
        {
            get
            {
                return this.itemCategoryId;
            }
            set
            {
                this.itemCategoryId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itemwatcherscounter    
        {
            get
            {
                return this.itemWatchersCounter;
            }
            set
            {
                this.itemWatchersCounter = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itemviewscounter    
        {
            get
            {
                return this.itemViewsCounter;
            }
            set
            {
                this.itemViewsCounter = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string itemnote    
        {
            get
            {
                return this.itemNote;
            }
            set
            {
                this.itemNote = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itemspecialinfo    
        {
            get
            {
                return this.itemSpecialInfo;
            }
            set
            {
                this.itemSpecialInfo = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itemshopinfo    
        {
            get
            {
                return this.itemShopInfo;
            }
            set
            {
                this.itemShopInfo = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public long itemproductinfo    
        {
            get
            {
                return this.itemProductInfo;
            }
            set
            {
                this.itemProductInfo = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itempayuinfo    
        {
            get
            {
                return this.itemPayuInfo;
            }
            set
            {
                this.itemPayuInfo = value;
                            
            }
        }
    }

    public partial class NotWonItemStruct {
        [System.Xml.Serialization.XmlIgnore]
        public long itemid    
        {
            get
            {
                return this.itemId;
            }
            set
            {
                this.itemId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string itemtitle    
        {
            get
            {
                return this.itemTitle;
            }
            set
            {
                this.itemTitle = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string itemthumbnailurl    
        {
            get
            {
                return this.itemThumbnailUrl;
            }
            set
            {
                this.itemThumbnailUrl = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public ItemPriceStruct[] itemprice    
        {
            get
            {
                return this.itemPrice;
            }
            set
            {
                this.itemPrice = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itemleftquantity    
        {
            get
            {
                return this.itemLeftQuantity;
            }
            set
            {
                this.itemLeftQuantity = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itemquantitytype    
        {
            get
            {
                return this.itemQuantityType;
            }
            set
            {
                this.itemQuantityType = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public long itemendtime    
        {
            get
            {
                return this.itemEndTime;
            }
            set
            {
                this.itemEndTime = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string itemendtimeleft    
        {
            get
            {
                return this.itemEndTimeLeft;
            }
            set
            {
                this.itemEndTimeLeft = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public UserInfoStruct itemseller    
        {
            get
            {
                return this.itemSeller;
            }
            set
            {
                this.itemSeller = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itembidderscounter    
        {
            get
            {
                return this.itemBiddersCounter;
            }
            set
            {
                this.itemBiddersCounter = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public UserInfoStruct itemhighestbidder    
        {
            get
            {
                return this.itemHighestBidder;
            }
            set
            {
                this.itemHighestBidder = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itemcategoryid    
        {
            get
            {
                return this.itemCategoryId;
            }
            set
            {
                this.itemCategoryId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itemviewscounter    
        {
            get
            {
                return this.itemViewsCounter;
            }
            set
            {
                this.itemViewsCounter = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string itemnote    
        {
            get
            {
                return this.itemNote;
            }
            set
            {
                this.itemNote = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itemspecialinfo    
        {
            get
            {
                return this.itemSpecialInfo;
            }
            set
            {
                this.itemSpecialInfo = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itemshopinfo    
        {
            get
            {
                return this.itemShopInfo;
            }
            set
            {
                this.itemShopInfo = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public long itemproductinfo    
        {
            get
            {
                return this.itemProductInfo;
            }
            set
            {
                this.itemProductInfo = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itempayuinfo    
        {
            get
            {
                return this.itemPayuInfo;
            }
            set
            {
                this.itemPayuInfo = value;
                            
            }
        }
    }

    public partial class PackageInfoStruct {
        [System.Xml.Serialization.XmlIgnore]
        public int operatorid    
        {
            get
            {
                return this.operatorId;
            }
            set
            {
                this.operatorId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string packageid    
        {
            get
            {
                return this.packageId;
            }
            set
            {
                this.packageId = value;
                            
            }
        }
    }

    public partial class PaymentDetailsStruct {
        [System.Xml.Serialization.XmlIgnore]
        public long paytransdetailsitid    
        {
            get
            {
                return this.payTransDetailsItId;
            }
            set
            {
                this.payTransDetailsItId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public float paytransdetailsprice    
        {
            get
            {
                return this.payTransDetailsPrice;
            }
            set
            {
                this.payTransDetailsPrice = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int paytransdetailscount    
        {
            get
            {
                return this.payTransDetailsCount;
            }
            set
            {
                this.payTransDetailsCount = value;
                            
            }
        }
    }

    public partial class PaymentItemsStruct {
        [System.Xml.Serialization.XmlIgnore]
        public long paytransitid    
        {
            get
            {
                return this.payTransItId;
            }
            set
            {
                this.payTransItId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string paytransitname    
        {
            get
            {
                return this.payTransItName;
            }
            set
            {
                this.payTransItName = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int paytransitcount    
        {
            get
            {
                return this.payTransItCount;
            }
            set
            {
                this.payTransItCount = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public float paytransitprice    
        {
            get
            {
                return this.payTransItPrice;
            }
            set
            {
                this.payTransItPrice = value;
                            
            }
        }
    }

    public partial class PaymentMethodStruct {
        [System.Xml.Serialization.XmlIgnore]
        public string paymentmethodid    
        {
            get
            {
                return this.paymentMethodId;
            }
            set
            {
                this.paymentMethodId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string paymentmethodname    
        {
            get
            {
                return this.paymentMethodName;
            }
            set
            {
                this.paymentMethodName = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string paymentmethodimage    
        {
            get
            {
                return this.paymentMethodImage;
            }
            set
            {
                this.paymentMethodImage = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int paymentmethodusage    
        {
            get
            {
                return this.paymentMethodUsage;
            }
            set
            {
                this.paymentMethodUsage = value;
                            
            }
        }
    }

    public partial class PaymentSellersStruct {
        [System.Xml.Serialization.XmlIgnore]
        public int paytranssellerid    
        {
            get
            {
                return this.payTransSellerId;
            }
            set
            {
                this.payTransSellerId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string paytranssellername    
        {
            get
            {
                return this.payTransSellerName;
            }
            set
            {
                this.payTransSellerName = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public PaymentItemsStruct[] paytransitems    
        {
            get
            {
                return this.payTransItems;
            }
            set
            {
                this.payTransItems = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public float paytranssellerpostageamount    
        {
            get
            {
                return this.payTransSellerPostageAmount;
            }
            set
            {
                this.payTransSellerPostageAmount = value;
                            
            }
        }
    }

    public partial class PaymentsInfoStruct {
        [System.Xml.Serialization.XmlIgnore]
        public float paymentsbalance    
        {
            get
            {
                return this.paymentsBalance;
            }
            set
            {
                this.paymentsBalance = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string paymentsbankaccount    
        {
            get
            {
                return this.paymentsBankAccount;
            }
            set
            {
                this.paymentsBankAccount = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public PaymentsUserDataStruct paymentsuserdata    
        {
            get
            {
                return this.paymentsUserData;
            }
            set
            {
                this.paymentsUserData = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public PaymentsPayoutStruct paymentspayout    
        {
            get
            {
                return this.paymentsPayout;
            }
            set
            {
                this.paymentsPayout = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int paymentsnotifications    
        {
            get
            {
                return this.paymentsNotifications;
            }
            set
            {
                this.paymentsNotifications = value;
                            
            }
        }
    }

    public partial class PaymentsPayoutStruct {
        [System.Xml.Serialization.XmlIgnore]
        public int payouttype    
        {
            get
            {
                return this.payoutType;
            }
            set
            {
                this.payoutType = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public PayoutAutoSettingsStruct payoutautosettings    
        {
            get
            {
                return this.payoutAutoSettings;
            }
            set
            {
                this.payoutAutoSettings = value;
                            
            }
        }
    }

    public partial class PaymentsUserDataStruct {
        [System.Xml.Serialization.XmlIgnore]
        public string userfullname    
        {
            get
            {
                return this.userFullName;
            }
            set
            {
                this.userFullName = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string useraddress    
        {
            get
            {
                return this.userAddress;
            }
            set
            {
                this.userAddress = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string userpostcode    
        {
            get
            {
                return this.userPostcode;
            }
            set
            {
                this.userPostcode = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string usercity    
        {
            get
            {
                return this.userCity;
            }
            set
            {
                this.userCity = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int usercountry    
        {
            get
            {
                return this.userCountry;
            }
            set
            {
                this.userCountry = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string userphone    
        {
            get
            {
                return this.userPhone;
            }
            set
            {
                this.userPhone = value;
                            
            }
        }
    }

    public partial class PayoutAutoFrequencyStruct {
        [System.Xml.Serialization.XmlIgnore]
        public short frequencytype    
        {
            get
            {
                return this.frequencyType;
            }
            set
            {
                this.frequencyType = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public short frequencyweekvalue    
        {
            get
            {
                return this.frequencyWeekValue;
            }
            set
            {
                this.frequencyWeekValue = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public short frequencymonthvalue    
        {
            get
            {
                return this.frequencyMonthValue;
            }
            set
            {
                this.frequencyMonthValue = value;
                            
            }
        }
    }

    public partial class PayoutAutoSettingsStruct {
        [System.Xml.Serialization.XmlIgnore]
        public float payoutautoamount    
        {
            get
            {
                return this.payoutAutoAmount;
            }
            set
            {
                this.payoutAutoAmount = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public PayoutAutoFrequencyStruct payoutautofrequency    
        {
            get
            {
                return this.payoutAutoFrequency;
            }
            set
            {
                this.payoutAutoFrequency = value;
                            
            }
        }
    }

    public partial class PharmacyDataStruct {
        [System.Xml.Serialization.XmlIgnore]
        public string pharmacyopeningdate    
        {
            get
            {
                return this.pharmacyOpeningDate;
            }
            set
            {
                this.pharmacyOpeningDate = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string pharmacyexpirationdate    
        {
            get
            {
                return this.pharmacyExpirationDate;
            }
            set
            {
                this.pharmacyExpirationDate = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string pharmacyname    
        {
            get
            {
                return this.pharmacyName;
            }
            set
            {
                this.pharmacyName = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string pharmacypharmacistfullname    
        {
            get
            {
                return this.pharmacyPharmacistFullName;
            }
            set
            {
                this.pharmacyPharmacistFullName = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string pharmacyaddress    
        {
            get
            {
                return this.pharmacyAddress;
            }
            set
            {
                this.pharmacyAddress = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string pharmacypostcode    
        {
            get
            {
                return this.pharmacyPostcode;
            }
            set
            {
                this.pharmacyPostcode = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string pharmacycity    
        {
            get
            {
                return this.pharmacyCity;
            }
            set
            {
                this.pharmacyCity = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string pharmacycommune    
        {
            get
            {
                return this.pharmacyCommune;
            }
            set
            {
                this.pharmacyCommune = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int pharmacycountryid    
        {
            get
            {
                return this.pharmacyCountryId;
            }
            set
            {
                this.pharmacyCountryId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int pharmacystateid    
        {
            get
            {
                return this.pharmacyStateId;
            }
            set
            {
                this.pharmacyStateId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string pharmacypermitnumber    
        {
            get
            {
                return this.pharmacyPermitNumber;
            }
            set
            {
                this.pharmacyPermitNumber = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string pharmacypermitinfo    
        {
            get
            {
                return this.pharmacyPermitInfo;
            }
            set
            {
                this.pharmacyPermitInfo = value;
                            
            }
        }
    }

    public partial class PharmacyRecipientDataStruct {
        [System.Xml.Serialization.XmlIgnore]
        public string recipientfirstname    
        {
            get
            {
                return this.recipientFirstName;
            }
            set
            {
                this.recipientFirstName = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string recipientlastname    
        {
            get
            {
                return this.recipientLastName;
            }
            set
            {
                this.recipientLastName = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string recipientaddress    
        {
            get
            {
                return this.recipientAddress;
            }
            set
            {
                this.recipientAddress = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string recipientpostcode    
        {
            get
            {
                return this.recipientPostcode;
            }
            set
            {
                this.recipientPostcode = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string recipientcity    
        {
            get
            {
                return this.recipientCity;
            }
            set
            {
                this.recipientCity = value;
                            
            }
        }
    }

    public partial class PostBuyFormAddressStruct {
        [System.Xml.Serialization.XmlIgnore]
        public int postbuyformadrcountry    
        {
            get
            {
                return this.postBuyFormAdrCountry;
            }
            set
            {
                this.postBuyFormAdrCountry = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string postbuyformadrstreet    
        {
            get
            {
                return this.postBuyFormAdrStreet;
            }
            set
            {
                this.postBuyFormAdrStreet = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string postbuyformadrpostcode    
        {
            get
            {
                return this.postBuyFormAdrPostcode;
            }
            set
            {
                this.postBuyFormAdrPostcode = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string postbuyformadrcity    
        {
            get
            {
                return this.postBuyFormAdrCity;
            }
            set
            {
                this.postBuyFormAdrCity = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string postbuyformadrfullname    
        {
            get
            {
                return this.postBuyFormAdrFullName;
            }
            set
            {
                this.postBuyFormAdrFullName = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string postbuyformadrcompany    
        {
            get
            {
                return this.postBuyFormAdrCompany;
            }
            set
            {
                this.postBuyFormAdrCompany = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string postbuyformadrphone    
        {
            get
            {
                return this.postBuyFormAdrPhone;
            }
            set
            {
                this.postBuyFormAdrPhone = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string postbuyformadrnip    
        {
            get
            {
                return this.postBuyFormAdrNip;
            }
            set
            {
                this.postBuyFormAdrNip = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string postbuyformcreateddate    
        {
            get
            {
                return this.postBuyFormCreatedDate;
            }
            set
            {
                this.postBuyFormCreatedDate = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int postbuyformadrtype    
        {
            get
            {
                return this.postBuyFormAdrType;
            }
            set
            {
                this.postBuyFormAdrType = value;
                            
            }
        }
    }

    public partial class PostBuyFormDataStruct {
        [System.Xml.Serialization.XmlIgnore]
        public long postbuyformid    
        {
            get
            {
                return this.postBuyFormId;
            }
            set
            {
                this.postBuyFormId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public PostBuyFormItemStruct[] postbuyformitems    
        {
            get
            {
                return this.postBuyFormItems;
            }
            set
            {
                this.postBuyFormItems = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public long postbuyformbuyerid    
        {
            get
            {
                return this.postBuyFormBuyerId;
            }
            set
            {
                this.postBuyFormBuyerId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public float postbuyformamount    
        {
            get
            {
                return this.postBuyFormAmount;
            }
            set
            {
                this.postBuyFormAmount = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public float postbuyformpostageamount    
        {
            get
            {
                return this.postBuyFormPostageAmount;
            }
            set
            {
                this.postBuyFormPostageAmount = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int postbuyforminvoiceoption    
        {
            get
            {
                return this.postBuyFormInvoiceOption;
            }
            set
            {
                this.postBuyFormInvoiceOption = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string postbuyformmsgtoseller    
        {
            get
            {
                return this.postBuyFormMsgToSeller;
            }
            set
            {
                this.postBuyFormMsgToSeller = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public PostBuyFormAddressStruct postbuyforminvoicedata    
        {
            get
            {
                return this.postBuyFormInvoiceData;
            }
            set
            {
                this.postBuyFormInvoiceData = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public PostBuyFormAddressStruct postbuyformshipmentaddress    
        {
            get
            {
                return this.postBuyFormShipmentAddress;
            }
            set
            {
                this.postBuyFormShipmentAddress = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string postbuyformpaytype    
        {
            get
            {
                return this.postBuyFormPayType;
            }
            set
            {
                this.postBuyFormPayType = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public long postbuyformpayid    
        {
            get
            {
                return this.postBuyFormPayId;
            }
            set
            {
                this.postBuyFormPayId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string postbuyformpaystatus    
        {
            get
            {
                return this.postBuyFormPayStatus;
            }
            set
            {
                this.postBuyFormPayStatus = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string postbuyformdateinit    
        {
            get
            {
                return this.postBuyFormDateInit;
            }
            set
            {
                this.postBuyFormDateInit = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string postbuyformdaterecv    
        {
            get
            {
                return this.postBuyFormDateRecv;
            }
            set
            {
                this.postBuyFormDateRecv = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string postbuyformdatecancel    
        {
            get
            {
                return this.postBuyFormDateCancel;
            }
            set
            {
                this.postBuyFormDateCancel = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int postbuyformshipmentid    
        {
            get
            {
                return this.postBuyFormShipmentId;
            }
            set
            {
                this.postBuyFormShipmentId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public PostBuyFormAddressStruct postbuyformgdaddress    
        {
            get
            {
                return this.postBuyFormGdAddress;
            }
            set
            {
                this.postBuyFormGdAddress = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public PostBuyFormShipmentTrackingStruct[] postbuyformshipmenttracking    
        {
            get
            {
                return this.postBuyFormShipmentTracking;
            }
            set
            {
                this.postBuyFormShipmentTracking = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public long[] postbuyformsurchargeslist    
        {
            get
            {
                return this.postBuyFormSurchargesList;
            }
            set
            {
                this.postBuyFormSurchargesList = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string postbuyformgdadditionalinfo    
        {
            get
            {
                return this.postBuyFormGdAdditionalInfo;
            }
            set
            {
                this.postBuyFormGdAdditionalInfo = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public float postbuyformpaymentamount    
        {
            get
            {
                return this.postBuyFormPaymentAmount;
            }
            set
            {
                this.postBuyFormPaymentAmount = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int postbuyformsentbyseller    
        {
            get
            {
                return this.postBuyFormSentBySeller;
            }
            set
            {
                this.postBuyFormSentBySeller = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string postbuyformbuyerlogin    
        {
            get
            {
                return this.postBuyFormBuyerLogin;
            }
            set
            {
                this.postBuyFormBuyerLogin = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string postbuyformbuyeremail    
        {
            get
            {
                return this.postBuyFormBuyerEmail;
            }
            set
            {
                this.postBuyFormBuyerEmail = value;
                            
            }
        }
    }

    public partial class PostBuyFormForBuyersDataStruct {
        [System.Xml.Serialization.XmlIgnore]
        public long postbuyformid    
        {
            get
            {
                return this.postBuyFormId;
            }
            set
            {
                this.postBuyFormId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int postbuyformbuyerid    
        {
            get
            {
                return this.postBuyFormBuyerId;
            }
            set
            {
                this.postBuyFormBuyerId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public PostBuyFormSellersStruct[] postbuyformsellers    
        {
            get
            {
                return this.postBuyFormSellers;
            }
            set
            {
                this.postBuyFormSellers = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public float postbuyformtotalamount    
        {
            get
            {
                return this.postBuyFormTotalAmount;
            }
            set
            {
                this.postBuyFormTotalAmount = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int postbuyforminvoiceoption    
        {
            get
            {
                return this.postBuyFormInvoiceOption;
            }
            set
            {
                this.postBuyFormInvoiceOption = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public PostBuyFormAddressStruct postbuyforminvoicedata    
        {
            get
            {
                return this.postBuyFormInvoiceData;
            }
            set
            {
                this.postBuyFormInvoiceData = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public PostBuyFormAddressStruct postbuyformshipmentaddress    
        {
            get
            {
                return this.postBuyFormShipmentAddress;
            }
            set
            {
                this.postBuyFormShipmentAddress = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string postbuyformpaytype    
        {
            get
            {
                return this.postBuyFormPayType;
            }
            set
            {
                this.postBuyFormPayType = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public long postbuyformpayid    
        {
            get
            {
                return this.postBuyFormPayId;
            }
            set
            {
                this.postBuyFormPayId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string postbuyformpaystatus    
        {
            get
            {
                return this.postBuyFormPayStatus;
            }
            set
            {
                this.postBuyFormPayStatus = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string postbuyformdateinit    
        {
            get
            {
                return this.postBuyFormDateInit;
            }
            set
            {
                this.postBuyFormDateInit = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string postbuyformdaterecv    
        {
            get
            {
                return this.postBuyFormDateRecv;
            }
            set
            {
                this.postBuyFormDateRecv = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string postbuyformdatecancel    
        {
            get
            {
                return this.postBuyFormDateCancel;
            }
            set
            {
                this.postBuyFormDateCancel = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public float postbuyformpaymentamount    
        {
            get
            {
                return this.postBuyFormPaymentAmount;
            }
            set
            {
                this.postBuyFormPaymentAmount = value;
                            
            }
        }
    }

    public partial class PostBuyFormItemStruct {
        [System.Xml.Serialization.XmlIgnore]
        public int postbuyformitquantity    
        {
            get
            {
                return this.postBuyFormItQuantity;
            }
            set
            {
                this.postBuyFormItQuantity = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public float postbuyformitamount    
        {
            get
            {
                return this.postBuyFormItAmount;
            }
            set
            {
                this.postBuyFormItAmount = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public long postbuyformitid    
        {
            get
            {
                return this.postBuyFormItId;
            }
            set
            {
                this.postBuyFormItId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string postbuyformittitle    
        {
            get
            {
                return this.postBuyFormItTitle;
            }
            set
            {
                this.postBuyFormItTitle = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int postbuyformitcountry    
        {
            get
            {
                return this.postBuyFormItCountry;
            }
            set
            {
                this.postBuyFormItCountry = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public float postbuyformitprice    
        {
            get
            {
                return this.postBuyFormItPrice;
            }
            set
            {
                this.postBuyFormItPrice = value;
                            
            }
        }
    }

    public partial class PostBuyFormPackageInfoStruct {
        [System.Xml.Serialization.XmlIgnore]
        public string[] packageidsadded    
        {
            get
            {
                return this.packageIdsAdded;
            }
            set
            {
                this.packageIdsAdded = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string[] packageidsnotaddedincorrectoperatorid    
        {
            get
            {
                return this.packageIdsNotAddedIncorrectOperatorId;
            }
            set
            {
                this.packageIdsNotAddedIncorrectOperatorId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string[] packageidsnotaddedincorrectpackageid    
        {
            get
            {
                return this.packageIdsNotAddedIncorrectPackageId;
            }
            set
            {
                this.packageIdsNotAddedIncorrectPackageId = value;
                            
            }
        }
    }

    public partial class PostBuyFormSellersStruct {
        [System.Xml.Serialization.XmlIgnore]
        public int postbuyformsellerid    
        {
            get
            {
                return this.postBuyFormSellerId;
            }
            set
            {
                this.postBuyFormSellerId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string postbuyformsellername    
        {
            get
            {
                return this.postBuyFormSellerName;
            }
            set
            {
                this.postBuyFormSellerName = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public PostBuyFormItemStruct[] postbuyformitems    
        {
            get
            {
                return this.postBuyFormItems;
            }
            set
            {
                this.postBuyFormItems = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int postbuyformshipmentid    
        {
            get
            {
                return this.postBuyFormShipmentId;
            }
            set
            {
                this.postBuyFormShipmentId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public float postbuyformpostageamount    
        {
            get
            {
                return this.postBuyFormPostageAmount;
            }
            set
            {
                this.postBuyFormPostageAmount = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string postbuyformmsgtoseller    
        {
            get
            {
                return this.postBuyFormMsgToSeller;
            }
            set
            {
                this.postBuyFormMsgToSeller = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public float postbuyformamount    
        {
            get
            {
                return this.postBuyFormAmount;
            }
            set
            {
                this.postBuyFormAmount = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public long[] postbuyformsurchargeslist    
        {
            get
            {
                return this.postBuyFormSurchargesList;
            }
            set
            {
                this.postBuyFormSurchargesList = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public PostBuyFormShipmentTrackingStruct[] postbuyformshipmenttracking    
        {
            get
            {
                return this.postBuyFormShipmentTracking;
            }
            set
            {
                this.postBuyFormShipmentTracking = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public PostBuyFormAddressStruct postbuyformgdaddress    
        {
            get
            {
                return this.postBuyFormGdAddress;
            }
            set
            {
                this.postBuyFormGdAddress = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string postbuyformgdadditionalinfo    
        {
            get
            {
                return this.postBuyFormGdAdditionalInfo;
            }
            set
            {
                this.postBuyFormGdAdditionalInfo = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int postbuyformsentbyseller    
        {
            get
            {
                return this.postBuyFormSentBySeller;
            }
            set
            {
                this.postBuyFormSentBySeller = value;
                            
            }
        }
    }

    public partial class PostBuyFormShipmentTrackingStruct {
        [System.Xml.Serialization.XmlIgnore]
        public int postbuyformoperatorid    
        {
            get
            {
                return this.postBuyFormOperatorId;
            }
            set
            {
                this.postBuyFormOperatorId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string postbuyformpackageid    
        {
            get
            {
                return this.postBuyFormPackageId;
            }
            set
            {
                this.postBuyFormPackageId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string postbuyformpackagestatus    
        {
            get
            {
                return this.postBuyFormPackageStatus;
            }
            set
            {
                this.postBuyFormPackageStatus = value;
                            
            }
        }
    }

    public partial class PostBuyFormStruct {
        [System.Xml.Serialization.XmlIgnore]
        public long transactionid    
        {
            get
            {
                return this.transactionId;
            }
            set
            {
                this.transactionId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public long[] transactionpackageids    
        {
            get
            {
                return this.transactionPackageIds;
            }
            set
            {
                this.transactionPackageIds = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public TransactionPayByLinkStruct transactionpaybylink    
        {
            get
            {
                return this.transactionPayByLink;
            }
            set
            {
                this.transactionPayByLink = value;
                            
            }
        }
    }

    public partial class PostBuyItemInfoStruct {
        [System.Xml.Serialization.XmlIgnore]
        public long itemid    
        {
            get
            {
                return this.itemId;
            }
            set
            {
                this.itemId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itempostbuyforminfo    
        {
            get
            {
                return this.itemPostBuyFormInfo;
            }
            set
            {
                this.itemPostBuyFormInfo = value;
                            
            }
        }
    }

    public partial class PostageStruct {
        [System.Xml.Serialization.XmlIgnore]
        public float postageamount    
        {
            get
            {
                return this.postageAmount;
            }
            set
            {
                this.postageAmount = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public float postageamountadd    
        {
            get
            {
                return this.postageAmountAdd;
            }
            set
            {
                this.postageAmountAdd = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int postagepacksize    
        {
            get
            {
                return this.postagePackSize;
            }
            set
            {
                this.postagePackSize = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int postageid    
        {
            get
            {
                return this.postageId;
            }
            set
            {
                this.postageId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int postagefreeshipping    
        {
            get
            {
                return this.postageFreeShipping;
            }
            set
            {
                this.postageFreeShipping = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public FulfillmentTimeStruct postagefulfillmenttime    
        {
            get
            {
                return this.postageFulfillmentTime;
            }
            set
            {
                this.postageFulfillmentTime = value;
                            
            }
        }
    }

    public partial class PriceCatInfo {
        [System.Xml.Serialization.XmlIgnore]
        public float pricemin    
        {
            get
            {
                return this.priceMin;
            }
            set
            {
                this.priceMin = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public float pricemax    
        {
            get
            {
                return this.priceMax;
            }
            set
            {
                this.priceMax = value;
                            
            }
        }
    }

    public partial class PriceStruct {
        [System.Xml.Serialization.XmlIgnore]
        public float priceamount    
        {
            get
            {
                return this.priceAmount;
            }
            set
            {
                this.priceAmount = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string pricecurrency    
        {
            get
            {
                return this.priceCurrency;
            }
            set
            {
                this.priceCurrency = value;
                            
            }
        }
    }

    public partial class ProductParametersGroupStruct {
        [System.Xml.Serialization.XmlIgnore]
        public string productparametersgroupname    
        {
            get
            {
                return this.productParametersGroupName;
            }
            set
            {
                this.productParametersGroupName = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public ProductParametersStruct[] productparameterslist    
        {
            get
            {
                return this.productParametersList;
            }
            set
            {
                this.productParametersList = value;
                            
            }
        }
    }

    public partial class ProductParametersStruct {
        [System.Xml.Serialization.XmlIgnore]
        public string productparametername    
        {
            get
            {
                return this.productParameterName;
            }
            set
            {
                this.productParameterName = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string[] productparametervalues    
        {
            get
            {
                return this.productParameterValues;
            }
            set
            {
                this.productParameterValues = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string productparameterdescription    
        {
            get
            {
                return this.productParameterDescription;
            }
            set
            {
                this.productParameterDescription = value;
                            
            }
        }
    }

    public partial class ProductStruct {
        [System.Xml.Serialization.XmlIgnore]
        public long productid    
        {
            get
            {
                return this.productId;
            }
            set
            {
                this.productId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string productname    
        {
            get
            {
                return this.productName;
            }
            set
            {
                this.productName = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string productdescription    
        {
            get
            {
                return this.productDescription;
            }
            set
            {
                this.productDescription = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string[] productimageslist    
        {
            get
            {
                return this.productImagesList;
            }
            set
            {
                this.productImagesList = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public ProductParametersGroupStruct[] productparametersgrouplist    
        {
            get
            {
                return this.productParametersGroupList;
            }
            set
            {
                this.productParametersGroupList = value;
                            
            }
        }
    }

    public partial class RangeDateValueStruct {
        [System.Xml.Serialization.XmlIgnore]
        public string fvaluerangedatemin    
        {
            get
            {
                return this.fvalueRangeDateMin;
            }
            set
            {
                this.fvalueRangeDateMin = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string fvaluerangedatemax    
        {
            get
            {
                return this.fvalueRangeDateMax;
            }
            set
            {
                this.fvalueRangeDateMax = value;
                            
            }
        }
    }

    public partial class RangeFloatValueStruct {
        [System.Xml.Serialization.XmlIgnore]
        public float fvaluerangefloatmin    
        {
            get
            {
                return this.fvalueRangeFloatMin;
            }
            set
            {
                this.fvalueRangeFloatMin = value;
                this.fvalueRangeFloatMinSpecified = true;            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public float fvaluerangefloatmax    
        {
            get
            {
                return this.fvalueRangeFloatMax;
            }
            set
            {
                this.fvalueRangeFloatMax = value;
                this.fvalueRangeFloatMaxSpecified = true;            
            }
        }
    }

    public partial class RangeIntValueStruct {
        [System.Xml.Serialization.XmlIgnore]
        public int fvaluerangeintmin    
        {
            get
            {
                return this.fvalueRangeIntMin;
            }
            set
            {
                this.fvalueRangeIntMin = value;
                this.fvalueRangeIntMinSpecified = true;            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int fvaluerangeintmax    
        {
            get
            {
                return this.fvalueRangeIntMax;
            }
            set
            {
                this.fvalueRangeIntMax = value;
                this.fvalueRangeIntMaxSpecified = true;            
            }
        }
    }

    public partial class RangeValueType {
        [System.Xml.Serialization.XmlIgnore]
        public string rangevaluemin    
        {
            get
            {
                return this.rangeValueMin;
            }
            set
            {
                this.rangeValueMin = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string rangevaluemax    
        {
            get
            {
                return this.rangeValueMax;
            }
            set
            {
                this.rangeValueMax = value;
                            
            }
        }
    }

    public partial class RefundDetailsType {
        [System.Xml.Serialization.XmlIgnore]
        public int refundid    
        {
            get
            {
                return this.refundId;
            }
            set
            {
                this.refundId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string refundstatus    
        {
            get
            {
                return this.refundStatus;
            }
            set
            {
                this.refundStatus = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int refundquantity    
        {
            get
            {
                return this.refundQuantity;
            }
            set
            {
                this.refundQuantity = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string createddate    
        {
            get
            {
                return this.createdDate;
            }
            set
            {
                this.createdDate = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string considerdate    
        {
            get
            {
                return this.considerDate;
            }
            set
            {
                this.considerDate = value;
                            
            }
        }
    }

    public partial class RefundFormDataStruct {
        [System.Xml.Serialization.XmlIgnore]
        public long refformitid    
        {
            get
            {
                return this.refFormItId;
            }
            set
            {
                this.refFormItId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string refformitname    
        {
            get
            {
                return this.refFormItName;
            }
            set
            {
                this.refFormItName = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public long refformitendingtime    
        {
            get
            {
                return this.refFormItEndingTime;
            }
            set
            {
                this.refFormItEndingTime = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int refformbuyerid    
        {
            get
            {
                return this.refFormBuyerId;
            }
            set
            {
                this.refFormBuyerId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string refformbuyerlogin    
        {
            get
            {
                return this.refFormBuyerLogin;
            }
            set
            {
                this.refFormBuyerLogin = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string refformbuyeremail    
        {
            get
            {
                return this.refFormBuyerEmail;
            }
            set
            {
                this.refFormBuyerEmail = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public long refformbuydate    
        {
            get
            {
                return this.refFormBuyDate;
            }
            set
            {
                this.refFormBuyDate = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int refformreasonid    
        {
            get
            {
                return this.refFormReasonId;
            }
            set
            {
                this.refFormReasonId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int refformitquantitysold    
        {
            get
            {
                return this.refFormItQuantitySold;
            }
            set
            {
                this.refFormItQuantitySold = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int refformremindersent    
        {
            get
            {
                return this.refFormReminderSent;
            }
            set
            {
                this.refFormReminderSent = value;
                            
            }
        }
    }

    public partial class RefundFormStatusResultStruct {
        [System.Xml.Serialization.XmlIgnore]
        public long itemid    
        {
            get
            {
                return this.itemId;
            }
            set
            {
                this.itemId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int buyerid    
        {
            get
            {
                return this.buyerId;
            }
            set
            {
                this.buyerId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int refundformstatus    
        {
            get
            {
                return this.refundFormStatus;
            }
            set
            {
                this.refundFormStatus = value;
                            
            }
        }
    }

    public partial class RefundFormStatusStruct {
        [System.Xml.Serialization.XmlIgnore]
        public long itemid    
        {
            get
            {
                return this.itemId;
            }
            set
            {
                this.itemId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int buyerid    
        {
            get
            {
                return this.buyerId;
            }
            set
            {
                this.buyerId = value;
                            
            }
        }
    }

    public partial class RefundListType {
        [System.Xml.Serialization.XmlIgnore]
        public long dealid    
        {
            get
            {
                return this.dealId;
            }
            set
            {
                this.dealId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public System.DateTime dealdate    
        {
            get
            {
                return this.dealDate;
            }
            set
            {
                this.dealDate = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int buyerid    
        {
            get
            {
                return this.buyerId;
            }
            set
            {
                this.buyerId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string buyerlogin    
        {
            get
            {
                return this.buyerLogin;
            }
            set
            {
                this.buyerLogin = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public long itemid    
        {
            get
            {
                return this.itemId;
            }
            set
            {
                this.itemId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string itemtitle    
        {
            get
            {
                return this.itemTitle;
            }
            set
            {
                this.itemTitle = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int bidscount    
        {
            get
            {
                return this.bidsCount;
            }
            set
            {
                this.bidsCount = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string quantitytype    
        {
            get
            {
                return this.quantityType;
            }
            set
            {
                this.quantityType = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public RefundDetailsType refunddetails    
        {
            get
            {
                return this.refundDetails;
            }
            set
            {
                this.refundDetails = value;
                            
            }
        }
    }

    public partial class RefundReasonStruct {
        [System.Xml.Serialization.XmlIgnore]
        public int refundreasonid    
        {
            get
            {
                return this.refundReasonId;
            }
            set
            {
                this.refundReasonId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string refundreasonname    
        {
            get
            {
                return this.refundReasonName;
            }
            set
            {
                this.refundReasonName = value;
                            
            }
        }
    }

    public partial class RefundsDealsListType {
        [System.Xml.Serialization.XmlIgnore]
        public long dealid    
        {
            get
            {
                return this.dealId;
            }
            set
            {
                this.dealId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public System.DateTime dealdate    
        {
            get
            {
                return this.dealDate;
            }
            set
            {
                this.dealDate = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int timeleft    
        {
            get
            {
                return this.timeLeft;
            }
            set
            {
                this.timeLeft = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int buyerid    
        {
            get
            {
                return this.buyerId;
            }
            set
            {
                this.buyerId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string buyerlogin    
        {
            get
            {
                return this.buyerLogin;
            }
            set
            {
                this.buyerLogin = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public long itemid    
        {
            get
            {
                return this.itemId;
            }
            set
            {
                this.itemId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string itemtitle    
        {
            get
            {
                return this.itemTitle;
            }
            set
            {
                this.itemTitle = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int bidscount    
        {
            get
            {
                return this.bidsCount;
            }
            set
            {
                this.bidsCount = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string quantitytype    
        {
            get
            {
                return this.quantityType;
            }
            set
            {
                this.quantityType = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string paymentstatus    
        {
            get
            {
                return this.paymentStatus;
            }
            set
            {
                this.paymentStatus = value;
                            
            }
        }
    }

    public partial class RelatedItemStruct {
        [System.Xml.Serialization.XmlIgnore]
        public long itemid    
        {
            get
            {
                return this.itemId;
            }
            set
            {
                this.itemId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string itemtitle    
        {
            get
            {
                return this.itemTitle;
            }
            set
            {
                this.itemTitle = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string itemthumbnail    
        {
            get
            {
                return this.itemThumbnail;
            }
            set
            {
                this.itemThumbnail = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public float itemprice    
        {
            get
            {
                return this.itemPrice;
            }
            set
            {
                this.itemPrice = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itemboughtcount    
        {
            get
            {
                return this.itemBoughtCount;
            }
            set
            {
                this.itemBoughtCount = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public float itemamount    
        {
            get
            {
                return this.itemAmount;
            }
            set
            {
                this.itemAmount = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itempaymenttype    
        {
            get
            {
                return this.itemPaymentType;
            }
            set
            {
                this.itemPaymentType = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public long itemsellerid    
        {
            get
            {
                return this.itemSellerId;
            }
            set
            {
                this.itemSellerId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string itemsellername    
        {
            get
            {
                return this.itemSellerName;
            }
            set
            {
                this.itemSellerName = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int iteminvoiceinfo    
        {
            get
            {
                return this.itemInvoiceInfo;
            }
            set
            {
                this.itemInvoiceInfo = value;
                            
            }
        }
    }

    public partial class RelatedItemsShipmentDataStruct {
        [System.Xml.Serialization.XmlIgnore]
        public SellerShipmentDataStruct[] sellershipmentdata    
        {
            get
            {
                return this.sellerShipmentData;
            }
            set
            {
                this.sellerShipmentData = value;
                            
            }
        }
    }

    public partial class RelatedItemsStruct {
        [System.Xml.Serialization.XmlIgnore]
        public RelatedItemStruct[] relateditemsinfo    
        {
            get
            {
                return this.relatedItemsInfo;
            }
            set
            {
                this.relatedItemsInfo = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public float relateditemsamount    
        {
            get
            {
                return this.relatedItemsAmount;
            }
            set
            {
                this.relatedItemsAmount = value;
                            
            }
        }
    }

    public partial class RelatedPersonsStruct {
        [System.Xml.Serialization.XmlIgnore]
        public string spousefirstname    
        {
            get
            {
                return this.spouseFirstName;
            }
            set
            {
                this.spouseFirstName = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string spouselastname    
        {
            get
            {
                return this.spouseLastName;
            }
            set
            {
                this.spouseLastName = value;
                            
            }
        }
    }

    public partial class RemovedItemTemplatesStruct {
        [System.Xml.Serialization.XmlIgnore]
        public int[] itemtemplateids    
        {
            get
            {
                return this.itemTemplateIds;
            }
            set
            {
                this.itemTemplateIds = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int[] itemtemplateincorrectids    
        {
            get
            {
                return this.itemTemplateIncorrectIds;
            }
            set
            {
                this.itemTemplateIncorrectIds = value;
                            
            }
        }
    }

    public partial class RequestPayoutStruct {
        [System.Xml.Serialization.XmlIgnore]
        public long payoutid    
        {
            get
            {
                return this.payoutId;
            }
            set
            {
                this.payoutId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public float payoutamount    
        {
            get
            {
                return this.payoutAmount;
            }
            set
            {
                this.payoutAmount = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public long payouttime    
        {
            get
            {
                return this.payoutTime;
            }
            set
            {
                this.payoutTime = value;
                            
            }
        }
    }

    public partial class SearchOptType {
        [System.Xml.Serialization.XmlIgnore]
        public string searchstring    
        {
            get
            {
                return this.searchString;
            }
            set
            {
                this.searchString = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int searchoptions    
        {
            get
            {
                return this.searchOptions;
            }
            set
            {
                this.searchOptions = value;
                this.searchOptionsSpecified = true;            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int searchorder    
        {
            get
            {
                return this.searchOrder;
            }
            set
            {
                this.searchOrder = value;
                this.searchOrderSpecified = true;            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int searchordertype    
        {
            get
            {
                return this.searchOrderType;
            }
            set
            {
                this.searchOrderType = value;
                this.searchOrderTypeSpecified = true;            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int searchcountry    
        {
            get
            {
                return this.searchCountry;
            }
            set
            {
                this.searchCountry = value;
                this.searchCountrySpecified = true;            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int searchcategory    
        {
            get
            {
                return this.searchCategory;
            }
            set
            {
                this.searchCategory = value;
                this.searchCategorySpecified = true;            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int searchoffset    
        {
            get
            {
                return this.searchOffset;
            }
            set
            {
                this.searchOffset = value;
                this.searchOffsetSpecified = true;            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string searchcity    
        {
            get
            {
                return this.searchCity;
            }
            set
            {
                this.searchCity = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int searchstate    
        {
            get
            {
                return this.searchState;
            }
            set
            {
                this.searchState = value;
                this.searchStateSpecified = true;            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public float searchpricefrom    
        {
            get
            {
                return this.searchPriceFrom;
            }
            set
            {
                this.searchPriceFrom = value;
                this.searchPriceFromSpecified = true;            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public float searchpriceto    
        {
            get
            {
                return this.searchPriceTo;
            }
            set
            {
                this.searchPriceTo = value;
                this.searchPriceToSpecified = true;            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int searchlimit    
        {
            get
            {
                return this.searchLimit;
            }
            set
            {
                this.searchLimit = value;
                this.searchLimitSpecified = true;            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int searchorderfulfillmenttime    
        {
            get
            {
                return this.searchOrderFulfillmentTime;
            }
            set
            {
                this.searchOrderFulfillmentTime = value;
                this.searchOrderFulfillmentTimeSpecified = true;            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int searchuser    
        {
            get
            {
                return this.searchUser;
            }
            set
            {
                this.searchUser = value;
                this.searchUserSpecified = true;            
            }
        }
    }

    public partial class SearchResponseType {
        [System.Xml.Serialization.XmlIgnore]
        public long sitid    
        {
            get
            {
                return this.sItId;
            }
            set
            {
                this.sItId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string sitname    
        {
            get
            {
                return this.sItName;
            }
            set
            {
                this.sItName = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public float sitprice    
        {
            get
            {
                return this.sItPrice;
            }
            set
            {
                this.sItPrice = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public float sitstartingprice    
        {
            get
            {
                return this.sItStartingPrice;
            }
            set
            {
                this.sItStartingPrice = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int sitisbuynow    
        {
            get
            {
                return this.sItIsBuyNow;
            }
            set
            {
                this.sItIsBuyNow = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public float sitbuynowprice    
        {
            get
            {
                return this.sItBuyNowPrice;
            }
            set
            {
                this.sItBuyNowPrice = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int sitbidcount    
        {
            get
            {
                return this.sItBidCount;
            }
            set
            {
                this.sItBidCount = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int sitfotocount    
        {
            get
            {
                return this.sItFotoCount;
            }
            set
            {
                this.sItFotoCount = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public long sitstartingtime    
        {
            get
            {
                return this.sItStartingTime;
            }
            set
            {
                this.sItStartingTime = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public long sitendingtime    
        {
            get
            {
                return this.sItEndingTime;
            }
            set
            {
                this.sItEndingTime = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public long sittimeleft    
        {
            get
            {
                return this.sItTimeLeft;
            }
            set
            {
                this.sItTimeLeft = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string sitcity    
        {
            get
            {
                return this.sItCity;
            }
            set
            {
                this.sItCity = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int sitstate    
        {
            get
            {
                return this.sItState;
            }
            set
            {
                this.sItState = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int sitcountry    
        {
            get
            {
                return this.sItCountry;
            }
            set
            {
                this.sItCountry = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int sitcategoryid    
        {
            get
            {
                return this.sItCategoryId;
            }
            set
            {
                this.sItCategoryId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int sitfeatured    
        {
            get
            {
                return this.sItFeatured;
            }
            set
            {
                this.sItFeatured = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string sitthumburl    
        {
            get
            {
                return this.sItThumbUrl;
            }
            set
            {
                this.sItThumbUrl = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int sitthumb    
        {
            get
            {
                return this.sItThumb;
            }
            set
            {
                this.sItThumb = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public float sitpostage    
        {
            get
            {
                return this.sItPostage;
            }
            set
            {
                this.sItPostage = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int sitisforguests    
        {
            get
            {
                return this.sItIsForGuests;
            }
            set
            {
                this.sItIsForGuests = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int sitistablicaadvert    
        {
            get
            {
                return this.sItIsTablicaAdvert;
            }
            set
            {
                this.sItIsTablicaAdvert = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int sitisallegrostandard    
        {
            get
            {
                return this.sItIsAllegroStandard;
            }
            set
            {
                this.sItIsAllegroStandard = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int sithasfreeshipping    
        {
            get
            {
                return this.sItHasFreeShipping;
            }
            set
            {
                this.sItHasFreeShipping = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int sitinstallmentsavailable    
        {
            get
            {
                return this.sItInstallmentsAvailable;
            }
            set
            {
                this.sItInstallmentsAvailable = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int sitorderfulfillmenttime    
        {
            get
            {
                return this.sItOrderFulfillmentTime;
            }
            set
            {
                this.sItOrderFulfillmentTime = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public AdvertInfoStruct sitadvertinfo    
        {
            get
            {
                return this.sItAdvertInfo;
            }
            set
            {
                this.sItAdvertInfo = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public SellerInfoStruct sitsellerinfo    
        {
            get
            {
                return this.sItSellerInfo;
            }
            set
            {
                this.sItSellerInfo = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public AttribStruct[] sitattribslist    
        {
            get
            {
                return this.sItAttribsList;
            }
            set
            {
                this.sItAttribsList = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int sitfulfillmenttime    
        {
            get
            {
                return this.sItFulfillmentTime;
            }
            set
            {
                this.sItFulfillmentTime = value;
                            
            }
        }
    }

    public partial class SellFilterOptionsStruct {
        [System.Xml.Serialization.XmlIgnore]
        public int filterformat    
        {
            get
            {
                return this.filterFormat;
            }
            set
            {
                this.filterFormat = value;
                this.filterFormatSpecified = true;            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int filterbids    
        {
            get
            {
                return this.filterBids;
            }
            set
            {
                this.filterBids = value;
                this.filterBidsSpecified = true;            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int filtertoend    
        {
            get
            {
                return this.filterToEnd;
            }
            set
            {
                this.filterToEnd = value;
                this.filterToEndSpecified = true;            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int filterfromstart    
        {
            get
            {
                return this.filterFromStart;
            }
            set
            {
                this.filterFromStart = value;
                this.filterFromStartSpecified = true;            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int filterautolisting    
        {
            get
            {
                return this.filterAutoListing;
            }
            set
            {
                this.filterAutoListing = value;
                this.filterAutoListingSpecified = true;            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public FilterPriceStruct filterprice    
        {
            get
            {
                return this.filterPrice;
            }
            set
            {
                this.filterPrice = value;
                            
            }
        }
    }

    public partial class SellFormFieldsForCategoryStruct {
        [System.Xml.Serialization.XmlIgnore]
        public SellFormType[] sellformfieldslist    
        {
            get
            {
                return this.sellFormFieldsList;
            }
            set
            {
                this.sellFormFieldsList = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public long sellformfieldsversionkey    
        {
            get
            {
                return this.sellFormFieldsVersionKey;
            }
            set
            {
                this.sellFormFieldsVersionKey = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string sellformfieldscomponentvalue    
        {
            get
            {
                return this.sellFormFieldsComponentValue;
            }
            set
            {
                this.sellFormFieldsComponentValue = value;
                            
            }
        }
    }

    public partial class SellFormType {
        [System.Xml.Serialization.XmlIgnore]
        public int sellformid    
        {
            get
            {
                return this.sellFormId;
            }
            set
            {
                this.sellFormId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string sellformtitle    
        {
            get
            {
                return this.sellFormTitle;
            }
            set
            {
                this.sellFormTitle = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int sellformcat    
        {
            get
            {
                return this.sellFormCat;
            }
            set
            {
                this.sellFormCat = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int sellformtype    
        {
            get
            {
                return this.sellFormType;
            }
            set
            {
                this.sellFormType = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int sellformrestype    
        {
            get
            {
                return this.sellFormResType;
            }
            set
            {
                this.sellFormResType = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int sellformdefvalue    
        {
            get
            {
                return this.sellFormDefValue;
            }
            set
            {
                this.sellFormDefValue = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int sellformopt    
        {
            get
            {
                return this.sellFormOpt;
            }
            set
            {
                this.sellFormOpt = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int sellformpos    
        {
            get
            {
                return this.sellFormPos;
            }
            set
            {
                this.sellFormPos = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int sellformlength    
        {
            get
            {
                return this.sellFormLength;
            }
            set
            {
                this.sellFormLength = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string sellminvalue    
        {
            get
            {
                return this.sellMinValue;
            }
            set
            {
                this.sellMinValue = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string sellmaxvalue    
        {
            get
            {
                return this.sellMaxValue;
            }
            set
            {
                this.sellMaxValue = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string sellformdesc    
        {
            get
            {
                return this.sellFormDesc;
            }
            set
            {
                this.sellFormDesc = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string sellformoptsvalues    
        {
            get
            {
                return this.sellFormOptsValues;
            }
            set
            {
                this.sellFormOptsValues = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string sellformfielddesc    
        {
            get
            {
                return this.sellFormFieldDesc;
            }
            set
            {
                this.sellFormFieldDesc = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int sellformparamid    
        {
            get
            {
                return this.sellFormParamId;
            }
            set
            {
                this.sellFormParamId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string sellformparamvalues    
        {
            get
            {
                return this.sellFormParamValues;
            }
            set
            {
                this.sellFormParamValues = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int sellformparentid    
        {
            get
            {
                return this.sellFormParentId;
            }
            set
            {
                this.sellFormParentId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string sellformparentvalue    
        {
            get
            {
                return this.sellFormParentValue;
            }
            set
            {
                this.sellFormParentValue = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string sellformunit    
        {
            get
            {
                return this.sellFormUnit;
            }
            set
            {
                this.sellFormUnit = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int sellformoptions    
        {
            get
            {
                return this.sellFormOptions;
            }
            set
            {
                this.sellFormOptions = value;
                            
            }
        }
    }

    public partial class SellItemStruct {
        [System.Xml.Serialization.XmlIgnore]
        public long itemid    
        {
            get
            {
                return this.itemId;
            }
            set
            {
                this.itemId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string itemtitle    
        {
            get
            {
                return this.itemTitle;
            }
            set
            {
                this.itemTitle = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string itemthumbnailurl    
        {
            get
            {
                return this.itemThumbnailUrl;
            }
            set
            {
                this.itemThumbnailUrl = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public ItemPriceStruct[] itemprice    
        {
            get
            {
                return this.itemPrice;
            }
            set
            {
                this.itemPrice = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itemstartquantity    
        {
            get
            {
                return this.itemStartQuantity;
            }
            set
            {
                this.itemStartQuantity = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itemsoldquantity    
        {
            get
            {
                return this.itemSoldQuantity;
            }
            set
            {
                this.itemSoldQuantity = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itemquantitytype    
        {
            get
            {
                return this.itemQuantityType;
            }
            set
            {
                this.itemQuantityType = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public long itemstarttime    
        {
            get
            {
                return this.itemStartTime;
            }
            set
            {
                this.itemStartTime = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public long itemendtime    
        {
            get
            {
                return this.itemEndTime;
            }
            set
            {
                this.itemEndTime = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string itemendtimeleft    
        {
            get
            {
                return this.itemEndTimeLeft;
            }
            set
            {
                this.itemEndTimeLeft = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itembidderscounter    
        {
            get
            {
                return this.itemBiddersCounter;
            }
            set
            {
                this.itemBiddersCounter = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public UserInfoStruct itemhighestbidder    
        {
            get
            {
                return this.itemHighestBidder;
            }
            set
            {
                this.itemHighestBidder = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itemcategoryid    
        {
            get
            {
                return this.itemCategoryId;
            }
            set
            {
                this.itemCategoryId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itemwatcherscounter    
        {
            get
            {
                return this.itemWatchersCounter;
            }
            set
            {
                this.itemWatchersCounter = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itemviewscounter    
        {
            get
            {
                return this.itemViewsCounter;
            }
            set
            {
                this.itemViewsCounter = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string itemnote    
        {
            get
            {
                return this.itemNote;
            }
            set
            {
                this.itemNote = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itemspecialinfo    
        {
            get
            {
                return this.itemSpecialInfo;
            }
            set
            {
                this.itemSpecialInfo = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itemshopinfo    
        {
            get
            {
                return this.itemShopInfo;
            }
            set
            {
                this.itemShopInfo = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public long itemproductinfo    
        {
            get
            {
                return this.itemProductInfo;
            }
            set
            {
                this.itemProductInfo = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itempayuinfo    
        {
            get
            {
                return this.itemPayuInfo;
            }
            set
            {
                this.itemPayuInfo = value;
                            
            }
        }
    }

    public partial class SellRatingAveragePerMonthStruct {
        [System.Xml.Serialization.XmlIgnore]
        public string sellratingmonth    
        {
            get
            {
                return this.sellRatingMonth;
            }
            set
            {
                this.sellRatingMonth = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public SellRatingStatsStruct[] sellratingaveragevalues    
        {
            get
            {
                return this.sellRatingAverageValues;
            }
            set
            {
                this.sellRatingAverageValues = value;
                            
            }
        }
    }

    public partial class SellRatingAverageStruct {
        [System.Xml.Serialization.XmlIgnore]
        public string sellratinggrouptitle    
        {
            get
            {
                return this.sellRatingGroupTitle;
            }
            set
            {
                this.sellRatingGroupTitle = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public float sellratinggroupaverage    
        {
            get
            {
                return this.sellRatingGroupAverage;
            }
            set
            {
                this.sellRatingGroupAverage = value;
                            
            }
        }
    }

    public partial class SellRatingDetailStruct {
        [System.Xml.Serialization.XmlIgnore]
        public string sellratinggrouptitle    
        {
            get
            {
                return this.sellRatingGroupTitle;
            }
            set
            {
                this.sellRatingGroupTitle = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public SellRatingReasonSumStruct[] sellratingreasonssummary    
        {
            get
            {
                return this.sellRatingReasonsSummary;
            }
            set
            {
                this.sellRatingReasonsSummary = value;
                            
            }
        }
    }

    public partial class SellRatingEstimationStruct {
        [System.Xml.Serialization.XmlIgnore]
        public int sellratinggroupid    
        {
            get
            {
                return this.sellRatingGroupId;
            }
            set
            {
                this.sellRatingGroupId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int sellratinggroupestimation    
        {
            get
            {
                return this.sellRatingGroupEstimation;
            }
            set
            {
                this.sellRatingGroupEstimation = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int sellratingreasonid    
        {
            get
            {
                return this.sellRatingReasonId;
            }
            set
            {
                this.sellRatingReasonId = value;
                this.sellRatingReasonIdSpecified = true;            
            }
        }
    }

    public partial class SellRatingInfoStruct {
        [System.Xml.Serialization.XmlIgnore]
        public int sellratinggroupid    
        {
            get
            {
                return this.sellRatingGroupId;
            }
            set
            {
                this.sellRatingGroupId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string sellratinggrouptitle    
        {
            get
            {
                return this.sellRatingGroupTitle;
            }
            set
            {
                this.sellRatingGroupTitle = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public SellRatingReasonStruct[] sellratingreasons    
        {
            get
            {
                return this.sellRatingReasons;
            }
            set
            {
                this.sellRatingReasons = value;
                            
            }
        }
    }

    public partial class SellRatingReasonStruct {
        [System.Xml.Serialization.XmlIgnore]
        public int sellratingreasonid    
        {
            get
            {
                return this.sellRatingReasonId;
            }
            set
            {
                this.sellRatingReasonId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string sellratingreasontitle    
        {
            get
            {
                return this.sellRatingReasonTitle;
            }
            set
            {
                this.sellRatingReasonTitle = value;
                            
            }
        }
    }

    public partial class SellRatingReasonSumStruct {
        [System.Xml.Serialization.XmlIgnore]
        public string sellratingreasontitle    
        {
            get
            {
                return this.sellRatingReasonTitle;
            }
            set
            {
                this.sellRatingReasonTitle = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int sellratingreasoncount    
        {
            get
            {
                return this.sellRatingReasonCount;
            }
            set
            {
                this.sellRatingReasonCount = value;
                            
            }
        }
    }

    public partial class SellRatingStatsStruct {
        [System.Xml.Serialization.XmlIgnore]
        public string sellratinggrouptitle    
        {
            get
            {
                return this.sellRatingGroupTitle;
            }
            set
            {
                this.sellRatingGroupTitle = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string sellratinggroupstats    
        {
            get
            {
                return this.sellRatingGroupStats;
            }
            set
            {
                this.sellRatingGroupStats = value;
                            
            }
        }
    }

    public partial class SellerInfoStruct {
        [System.Xml.Serialization.XmlIgnore]
        public int sellerid    
        {
            get
            {
                return this.sellerId;
            }
            set
            {
                this.sellerId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string sellername    
        {
            get
            {
                return this.sellerName;
            }
            set
            {
                this.sellerName = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int sellerrating    
        {
            get
            {
                return this.sellerRating;
            }
            set
            {
                this.sellerRating = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int sellerinfo    
        {
            get
            {
                return this.sellerInfo;
            }
            set
            {
                this.sellerInfo = value;
                            
            }
        }
    }

    public partial class SellerPaymentInfoStruct {
        [System.Xml.Serialization.XmlIgnore]
        public ShipmentPaymentInfoStruct[] shipmentpaymentinfopza    
        {
            get
            {
                return this.shipmentPaymentInfoPza;
            }
            set
            {
                this.shipmentPaymentInfoPza = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public ShipmentPaymentInfoStruct[] shipmentpaymentinfononpza    
        {
            get
            {
                return this.shipmentPaymentInfoNonPza;
            }
            set
            {
                this.shipmentPaymentInfoNonPza = value;
                            
            }
        }
    }

    public partial class SellerShipmentDataStruct {
        [System.Xml.Serialization.XmlIgnore]
        public int sellerid    
        {
            get
            {
                return this.sellerId;
            }
            set
            {
                this.sellerId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public SellerPaymentInfoStruct sellerpaymentinfo    
        {
            get
            {
                return this.sellerPaymentInfo;
            }
            set
            {
                this.sellerPaymentInfo = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int sellerothershipmentisactive    
        {
            get
            {
                return this.sellerOtherShipmentIsActive;
            }
            set
            {
                this.sellerOtherShipmentIsActive = value;
                            
            }
        }
    }

    public partial class SendRefundFormResultStruct {
        [System.Xml.Serialization.XmlIgnore]
        public long itemid    
        {
            get
            {
                return this.itemId;
            }
            set
            {
                this.itemId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int buyerid    
        {
            get
            {
                return this.buyerId;
            }
            set
            {
                this.buyerId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int sendrefundresult    
        {
            get
            {
                return this.sendRefundResult;
            }
            set
            {
                this.sendRefundResult = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string sendrefunderrcode    
        {
            get
            {
                return this.sendRefundErrCode;
            }
            set
            {
                this.sendRefundErrCode = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string sendrefunderrmsg    
        {
            get
            {
                return this.sendRefundErrMsg;
            }
            set
            {
                this.sendRefundErrMsg = value;
                            
            }
        }
    }

    public partial class SendRefundFormStruct {
        [System.Xml.Serialization.XmlIgnore]
        public long itemid    
        {
            get
            {
                return this.itemId;
            }
            set
            {
                this.itemId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int buyerid    
        {
            get
            {
                return this.buyerId;
            }
            set
            {
                this.buyerId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int refundreason    
        {
            get
            {
                return this.refundReason;
            }
            set
            {
                this.refundReason = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itemquantitysold    
        {
            get
            {
                return this.itemQuantitySold;
            }
            set
            {
                this.itemQuantitySold = value;
                            
            }
        }
    }

    public partial class SendReminderMessageResultStruct {
        [System.Xml.Serialization.XmlIgnore]
        public long itemid    
        {
            get
            {
                return this.itemId;
            }
            set
            {
                this.itemId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int buyerid    
        {
            get
            {
                return this.buyerId;
            }
            set
            {
                this.buyerId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int remindermsgresult    
        {
            get
            {
                return this.reminderMsgResult;
            }
            set
            {
                this.reminderMsgResult = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string remindermsgerrcode    
        {
            get
            {
                return this.reminderMsgErrCode;
            }
            set
            {
                this.reminderMsgErrCode = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string remindermsgerrmsg    
        {
            get
            {
                return this.reminderMsgErrMsg;
            }
            set
            {
                this.reminderMsgErrMsg = value;
                            
            }
        }
    }

    public partial class SendReminderMessageStruct {
        [System.Xml.Serialization.XmlIgnore]
        public long itemid    
        {
            get
            {
                return this.itemId;
            }
            set
            {
                this.itemId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int buyerid    
        {
            get
            {
                return this.buyerId;
            }
            set
            {
                this.buyerId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string messagebody    
        {
            get
            {
                return this.messageBody;
            }
            set
            {
                this.messageBody = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int includemydata    
        {
            get
            {
                return this.includeMyData;
            }
            set
            {
                this.includeMyData = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int sendcctome    
        {
            get
            {
                return this.sendCcToMe;
            }
            set
            {
                this.sendCcToMe = value;
                            
            }
        }
    }

    public partial class ServiceInfoCatStruct {
        [System.Xml.Serialization.XmlIgnore]
        public int ancatid    
        {
            get
            {
                return this.anCatId;
            }
            set
            {
                this.anCatId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string ancatname    
        {
            get
            {
                return this.anCatName;
            }
            set
            {
                this.anCatName = value;
                            
            }
        }
    }

    public partial class ServiceInfoStruct {
        [System.Xml.Serialization.XmlIgnore]
        public int anitid    
        {
            get
            {
                return this.anItId;
            }
            set
            {
                this.anItId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int ancatid    
        {
            get
            {
                return this.anCatId;
            }
            set
            {
                this.anCatId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string anittitle    
        {
            get
            {
                return this.anItTitle;
            }
            set
            {
                this.anItTitle = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public byte[] anitbody    
        {
            get
            {
                return this.anItBody;
            }
            set
            {
                this.anItBody = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int countryid    
        {
            get
            {
                return this.countryId;
            }
            set
            {
                this.countryId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public long anitdate    
        {
            get
            {
                return this.anItDate;
            }
            set
            {
                this.anItDate = value;
                            
            }
        }
    }

    public partial class ShipmentDataStruct {
        [System.Xml.Serialization.XmlIgnore]
        public int shipmentid    
        {
            get
            {
                return this.shipmentId;
            }
            set
            {
                this.shipmentId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string shipmentname    
        {
            get
            {
                return this.shipmentName;
            }
            set
            {
                this.shipmentName = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int shipmenttype    
        {
            get
            {
                return this.shipmentType;
            }
            set
            {
                this.shipmentType = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public ShipmentTimeStruct shipmenttime    
        {
            get
            {
                return this.shipmentTime;
            }
            set
            {
                this.shipmentTime = value;
                            
            }
        }
    }

    public partial class ShipmentPaymentInfoStruct {
        [System.Xml.Serialization.XmlIgnore]
        public int shipmentid    
        {
            get
            {
                return this.shipmentId;
            }
            set
            {
                this.shipmentId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string shipmentname    
        {
            get
            {
                return this.shipmentName;
            }
            set
            {
                this.shipmentName = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public float shipmentamount    
        {
            get
            {
                return this.shipmentAmount;
            }
            set
            {
                this.shipmentAmount = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int shipmentpaymenttype    
        {
            get
            {
                return this.shipmentPaymentType;
            }
            set
            {
                this.shipmentPaymentType = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public long[] shipmentitemids    
        {
            get
            {
                return this.shipmentItemIds;
            }
            set
            {
                this.shipmentItemIds = value;
                            
            }
        }
    }

    public partial class ShipmentPriceTypeStruct {
        [System.Xml.Serialization.XmlIgnore]
        public int shipmentpricetypeid    
        {
            get
            {
                return this.shipmentPriceTypeId;
            }
            set
            {
                this.shipmentPriceTypeId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string shipmentpricetypename    
        {
            get
            {
                return this.shipmentPriceTypeName;
            }
            set
            {
                this.shipmentPriceTypeName = value;
                            
            }
        }
    }

    public partial class ShipmentTimeStruct {
        [System.Xml.Serialization.XmlIgnore]
        public int shipmenttimefrom    
        {
            get
            {
                return this.shipmentTimeFrom;
            }
            set
            {
                this.shipmentTimeFrom = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int shipmenttimeto    
        {
            get
            {
                return this.shipmentTimeTo;
            }
            set
            {
                this.shipmentTimeTo = value;
                            
            }
        }
    }

    public partial class ShowUserFeedbacks {
        [System.Xml.Serialization.XmlIgnore]
        public int userflastweek    
        {
            get
            {
                return this.userFLastWeek;
            }
            set
            {
                this.userFLastWeek = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int userflastmonth    
        {
            get
            {
                return this.userFLastMonth;
            }
            set
            {
                this.userFLastMonth = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int userfall    
        {
            get
            {
                return this.userFAll;
            }
            set
            {
                this.userFAll = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int userfsolditems    
        {
            get
            {
                return this.userFSoldItems;
            }
            set
            {
                this.userFSoldItems = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int userfbuyitems    
        {
            get
            {
                return this.userFBuyItems;
            }
            set
            {
                this.userFBuyItems = value;
                            
            }
        }
    }

    public partial class SiteFlagInfoType {
        [System.Xml.Serialization.XmlIgnore]
        public string sitename    
        {
            get
            {
                return this.siteName;
            }
            set
            {
                this.siteName = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string siteurl    
        {
            get
            {
                return this.siteUrl;
            }
            set
            {
                this.siteUrl = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int sitecountrycode    
        {
            get
            {
                return this.siteCountryCode;
            }
            set
            {
                this.siteCountryCode = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string sitecodepage    
        {
            get
            {
                return this.siteCodePage;
            }
            set
            {
                this.siteCodePage = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public byte[] sitelogogif    
        {
            get
            {
                return this.siteLogoGif;
            }
            set
            {
                this.siteLogoGif = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public byte[] siteflaggif    
        {
            get
            {
                return this.siteFlagGif;
            }
            set
            {
                this.siteFlagGif = value;
                            
            }
        }
    }

    public partial class SiteInfoType {
        [System.Xml.Serialization.XmlIgnore]
        public string sitename    
        {
            get
            {
                return this.siteName;
            }
            set
            {
                this.siteName = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string siteurl    
        {
            get
            {
                return this.siteUrl;
            }
            set
            {
                this.siteUrl = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int sitecountrycode    
        {
            get
            {
                return this.siteCountryCode;
            }
            set
            {
                this.siteCountryCode = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string sitecodepage    
        {
            get
            {
                return this.siteCodePage;
            }
            set
            {
                this.siteCodePage = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public byte[] sitelogogif    
        {
            get
            {
                return this.siteLogoGif;
            }
            set
            {
                this.siteLogoGif = value;
                            
            }
        }
    }

    public partial class SiteJournal {
        [System.Xml.Serialization.XmlIgnore]
        public long rowid    
        {
            get
            {
                return this.rowId;
            }
            set
            {
                this.rowId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public long itemid    
        {
            get
            {
                return this.itemId;
            }
            set
            {
                this.itemId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string changetype    
        {
            get
            {
                return this.changeType;
            }
            set
            {
                this.changeType = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public long changedate    
        {
            get
            {
                return this.changeDate;
            }
            set
            {
                this.changeDate = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public float currentprice    
        {
            get
            {
                return this.currentPrice;
            }
            set
            {
                this.currentPrice = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public long itemsellerid    
        {
            get
            {
                return this.itemSellerId;
            }
            set
            {
                this.itemSellerId = value;
                            
            }
        }
    }

    public partial class SiteJournalDealsInfoStruct {
        [System.Xml.Serialization.XmlIgnore]
        public int dealeventscount    
        {
            get
            {
                return this.dealEventsCount;
            }
            set
            {
                this.dealEventsCount = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public long deallasteventtime    
        {
            get
            {
                return this.dealLastEventTime;
            }
            set
            {
                this.dealLastEventTime = value;
                            
            }
        }
    }

    public partial class SiteJournalDealsStruct {
        [System.Xml.Serialization.XmlIgnore]
        public long dealeventid    
        {
            get
            {
                return this.dealEventId;
            }
            set
            {
                this.dealEventId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int dealeventtype    
        {
            get
            {
                return this.dealEventType;
            }
            set
            {
                this.dealEventType = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public long dealeventtime    
        {
            get
            {
                return this.dealEventTime;
            }
            set
            {
                this.dealEventTime = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public long dealid    
        {
            get
            {
                return this.dealId;
            }
            set
            {
                this.dealId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public long dealtransactionid    
        {
            get
            {
                return this.dealTransactionId;
            }
            set
            {
                this.dealTransactionId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int dealsellerid    
        {
            get
            {
                return this.dealSellerId;
            }
            set
            {
                this.dealSellerId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public long dealitemid    
        {
            get
            {
                return this.dealItemId;
            }
            set
            {
                this.dealItemId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int dealbuyerid    
        {
            get
            {
                return this.dealBuyerId;
            }
            set
            {
                this.dealBuyerId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int dealquantity    
        {
            get
            {
                return this.dealQuantity;
            }
            set
            {
                this.dealQuantity = value;
                            
            }
        }
    }

    public partial class SiteJournalInfo {
        [System.Xml.Serialization.XmlIgnore]
        public int itemsnumber    
        {
            get
            {
                return this.itemsNumber;
            }
            set
            {
                this.itemsNumber = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public long lastitemdate    
        {
            get
            {
                return this.lastItemDate;
            }
            set
            {
                this.lastItemDate = value;
                            
            }
        }
    }

    public partial class SoldFilterOptionsStruct {
        [System.Xml.Serialization.XmlIgnore]
        public int filterformat    
        {
            get
            {
                return this.filterFormat;
            }
            set
            {
                this.filterFormat = value;
                this.filterFormatSpecified = true;            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int filterfromend    
        {
            get
            {
                return this.filterFromEnd;
            }
            set
            {
                this.filterFromEnd = value;
                this.filterFromEndSpecified = true;            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int filterautolisting    
        {
            get
            {
                return this.filterAutoListing;
            }
            set
            {
                this.filterAutoListing = value;
                this.filterAutoListingSpecified = true;            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public FilterPriceStruct filterprice    
        {
            get
            {
                return this.filterPrice;
            }
            set
            {
                this.filterPrice = value;
                            
            }
        }
    }

    public partial class SoldItemStruct {
        [System.Xml.Serialization.XmlIgnore]
        public long itemid    
        {
            get
            {
                return this.itemId;
            }
            set
            {
                this.itemId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string itemtitle    
        {
            get
            {
                return this.itemTitle;
            }
            set
            {
                this.itemTitle = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string itemthumbnailurl    
        {
            get
            {
                return this.itemThumbnailUrl;
            }
            set
            {
                this.itemThumbnailUrl = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public ItemPriceStruct[] itemprice    
        {
            get
            {
                return this.itemPrice;
            }
            set
            {
                this.itemPrice = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itemstartquantity    
        {
            get
            {
                return this.itemStartQuantity;
            }
            set
            {
                this.itemStartQuantity = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itemsoldquantity    
        {
            get
            {
                return this.itemSoldQuantity;
            }
            set
            {
                this.itemSoldQuantity = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itemquantitytype    
        {
            get
            {
                return this.itemQuantityType;
            }
            set
            {
                this.itemQuantityType = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public long itemstarttime    
        {
            get
            {
                return this.itemStartTime;
            }
            set
            {
                this.itemStartTime = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public long itemendtime    
        {
            get
            {
                return this.itemEndTime;
            }
            set
            {
                this.itemEndTime = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string itemendtimeleft    
        {
            get
            {
                return this.itemEndTimeLeft;
            }
            set
            {
                this.itemEndTimeLeft = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itembidderscounter    
        {
            get
            {
                return this.itemBiddersCounter;
            }
            set
            {
                this.itemBiddersCounter = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public UserInfoStruct itemhighestbidder    
        {
            get
            {
                return this.itemHighestBidder;
            }
            set
            {
                this.itemHighestBidder = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itemcategoryid    
        {
            get
            {
                return this.itemCategoryId;
            }
            set
            {
                this.itemCategoryId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itemwatcherscounter    
        {
            get
            {
                return this.itemWatchersCounter;
            }
            set
            {
                this.itemWatchersCounter = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itemviewscounter    
        {
            get
            {
                return this.itemViewsCounter;
            }
            set
            {
                this.itemViewsCounter = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string itemnote    
        {
            get
            {
                return this.itemNote;
            }
            set
            {
                this.itemNote = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itemspecialinfo    
        {
            get
            {
                return this.itemSpecialInfo;
            }
            set
            {
                this.itemSpecialInfo = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itemshopinfo    
        {
            get
            {
                return this.itemShopInfo;
            }
            set
            {
                this.itemShopInfo = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public long itemproductinfo    
        {
            get
            {
                return this.itemProductInfo;
            }
            set
            {
                this.itemProductInfo = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itempayuinfo    
        {
            get
            {
                return this.itemPayuInfo;
            }
            set
            {
                this.itemPayuInfo = value;
                            
            }
        }
    }

    public partial class SortOptionsStruct {
        [System.Xml.Serialization.XmlIgnore]
        public int sorttype    
        {
            get
            {
                return this.sortType;
            }
            set
            {
                this.sortType = value;
                this.sortTypeSpecified = true;            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int sortorder    
        {
            get
            {
                return this.sortOrder;
            }
            set
            {
                this.sortOrder = value;
                this.sortOrderSpecified = true;            
            }
        }
    }

    public partial class SpecialAuctionStruct {
        [System.Xml.Serialization.XmlIgnore]
        public long itid    
        {
            get
            {
                return this.itId;
            }
            set
            {
                this.itId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string itname    
        {
            get
            {
                return this.itName;
            }
            set
            {
                this.itName = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public float itprice    
        {
            get
            {
                return this.itPrice;
            }
            set
            {
                this.itPrice = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public float itbuynowprice    
        {
            get
            {
                return this.itBuyNowPrice;
            }
            set
            {
                this.itBuyNowPrice = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itbidcount    
        {
            get
            {
                return this.itBidCount;
            }
            set
            {
                this.itBidCount = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itfotocount    
        {
            get
            {
                return this.itFotoCount;
            }
            set
            {
                this.itFotoCount = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public long ittimeleft    
        {
            get
            {
                return this.itTimeLeft;
            }
            set
            {
                this.itTimeLeft = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public long itendingtime    
        {
            get
            {
                return this.itEndingTime;
            }
            set
            {
                this.itEndingTime = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itcountry    
        {
            get
            {
                return this.itCountry;
            }
            set
            {
                this.itCountry = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itislistingthumb    
        {
            get
            {
                return this.itIsListingThumb;
            }
            set
            {
                this.itIsListingThumb = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itisescrow    
        {
            get
            {
                return this.itIsEscrow;
            }
            set
            {
                this.itIsEscrow = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public long itsellerid    
        {
            get
            {
                return this.itSellerId;
            }
            set
            {
                this.itSellerId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public float itsendcostprice    
        {
            get
            {
                return this.itSendCostPrice;
            }
            set
            {
                this.itSendCostPrice = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itisboldtitle    
        {
            get
            {
                return this.itIsBoldTitle;
            }
            set
            {
                this.itIsBoldTitle = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public long itstartingtime    
        {
            get
            {
                return this.itStartingTime;
            }
            set
            {
                this.itStartingTime = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itisallegrostandard    
        {
            get
            {
                return this.itIsAllegroStandard;
            }
            set
            {
                this.itIsAllegroStandard = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int ithasfreeshipping    
        {
            get
            {
                return this.itHasFreeShipping;
            }
            set
            {
                this.itHasFreeShipping = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public AttribStruct[] itattribslist    
        {
            get
            {
                return this.itAttribsList;
            }
            set
            {
                this.itAttribsList = value;
                            
            }
        }
    }

    public partial class StateInfoStruct {
        [System.Xml.Serialization.XmlIgnore]
        public int stateid    
        {
            get
            {
                return this.stateId;
            }
            set
            {
                this.stateId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string statename    
        {
            get
            {
                return this.stateName;
            }
            set
            {
                this.stateName = value;
                            
            }
        }
    }

    public partial class StructSellAgain {
        [System.Xml.Serialization.XmlIgnore]
        public long sellitemid    
        {
            get
            {
                return this.sellItemId;
            }
            set
            {
                this.sellItemId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string selliteminfo    
        {
            get
            {
                return this.sellItemInfo;
            }
            set
            {
                this.sellItemInfo = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int sellitemlocalid    
        {
            get
            {
                return this.sellItemLocalId;
            }
            set
            {
                this.sellItemLocalId = value;
                            
            }
        }
    }

    public partial class StructSellFailed {
        [System.Xml.Serialization.XmlIgnore]
        public long sellitemid    
        {
            get
            {
                return this.sellItemId;
            }
            set
            {
                this.sellItemId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string sellfaultcode    
        {
            get
            {
                return this.sellFaultCode;
            }
            set
            {
                this.sellFaultCode = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string sellfaultstring    
        {
            get
            {
                return this.sellFaultString;
            }
            set
            {
                this.sellFaultString = value;
                            
            }
        }
    }

    public partial class SysStatusType {
        [System.Xml.Serialization.XmlIgnore]
        public int countryid    
        {
            get
            {
                return this.countryId;
            }
            set
            {
                this.countryId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string programversion    
        {
            get
            {
                return this.programVersion;
            }
            set
            {
                this.programVersion = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string catsversion    
        {
            get
            {
                return this.catsVersion;
            }
            set
            {
                this.catsVersion = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string apiversion    
        {
            get
            {
                return this.apiVersion;
            }
            set
            {
                this.apiVersion = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string attribversion    
        {
            get
            {
                return this.attribVersion;
            }
            set
            {
                this.attribVersion = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string formsellversion    
        {
            get
            {
                return this.formSellVersion;
            }
            set
            {
                this.formSellVersion = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string siteversion    
        {
            get
            {
                return this.siteVersion;
            }
            set
            {
                this.siteVersion = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public long verkey    
        {
            get
            {
                return this.verKey;
            }
            set
            {
                this.verKey = value;
                            
            }
        }
    }

    public partial class TemplateInfoType {
        [System.Xml.Serialization.XmlIgnore]
        public int templateid    
        {
            get
            {
                return this.templateId;
            }
            set
            {
                this.templateId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string templatename    
        {
            get
            {
                return this.templateName;
            }
            set
            {
                this.templateName = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public byte[] templatethumb    
        {
            get
            {
                return this.templateThumb;
            }
            set
            {
                this.templateThumb = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public byte[] templatedescimages    
        {
            get
            {
                return this.templateDescImages;
            }
            set
            {
                this.templateDescImages = value;
                            
            }
        }
    }

    public partial class TransactionPayByLinkStruct {
        [System.Xml.Serialization.XmlIgnore]
        public string actionhttpmethod    
        {
            get
            {
                return this.actionHttpMethod;
            }
            set
            {
                this.actionHttpMethod = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string actionurl    
        {
            get
            {
                return this.actionUrl;
            }
            set
            {
                this.actionUrl = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public ActionDataStruct[] actiondata    
        {
            get
            {
                return this.actionData;
            }
            set
            {
                this.actionData = value;
                            
            }
        }
    }

    public partial class UserBlackListAddResultStruct {
        [System.Xml.Serialization.XmlIgnore]
        public int userid    
        {
            get
            {
                return this.userId;
            }
            set
            {
                this.userId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int addtoblacklistresult    
        {
            get
            {
                return this.addToBlackListResult;
            }
            set
            {
                this.addToBlackListResult = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string addtoblacklisterrcode    
        {
            get
            {
                return this.addToBlackListErrCode;
            }
            set
            {
                this.addToBlackListErrCode = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string addtoblacklisterrmsg    
        {
            get
            {
                return this.addToBlackListErrMsg;
            }
            set
            {
                this.addToBlackListErrMsg = value;
                            
            }
        }
    }

    public partial class UserBlackListStruct {
        [System.Xml.Serialization.XmlIgnore]
        public int userid    
        {
            get
            {
                return this.userId;
            }
            set
            {
                this.userId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string userblacklistnote    
        {
            get
            {
                return this.userBlackListNote;
            }
            set
            {
                this.userBlackListNote = value;
                            
            }
        }
    }

    public partial class UserDataStruct {
        [System.Xml.Serialization.XmlIgnore]
        public long userid    
        {
            get
            {
                return this.userId;
            }
            set
            {
                this.userId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string userlogin    
        {
            get
            {
                return this.userLogin;
            }
            set
            {
                this.userLogin = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int userrating    
        {
            get
            {
                return this.userRating;
            }
            set
            {
                this.userRating = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string userfirstname    
        {
            get
            {
                return this.userFirstName;
            }
            set
            {
                this.userFirstName = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string userlastname    
        {
            get
            {
                return this.userLastName;
            }
            set
            {
                this.userLastName = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string usermaidenname    
        {
            get
            {
                return this.userMaidenName;
            }
            set
            {
                this.userMaidenName = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string usercompany    
        {
            get
            {
                return this.userCompany;
            }
            set
            {
                this.userCompany = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int usercountryid    
        {
            get
            {
                return this.userCountryId;
            }
            set
            {
                this.userCountryId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int userstateid    
        {
            get
            {
                return this.userStateId;
            }
            set
            {
                this.userStateId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string userpostcode    
        {
            get
            {
                return this.userPostcode;
            }
            set
            {
                this.userPostcode = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string usercity    
        {
            get
            {
                return this.userCity;
            }
            set
            {
                this.userCity = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string useraddress    
        {
            get
            {
                return this.userAddress;
            }
            set
            {
                this.userAddress = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string useremail    
        {
            get
            {
                return this.userEmail;
            }
            set
            {
                this.userEmail = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string userphone    
        {
            get
            {
                return this.userPhone;
            }
            set
            {
                this.userPhone = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string userphone2    
        {
            get
            {
                return this.userPhone2;
            }
            set
            {
                this.userPhone2 = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int userssstatus    
        {
            get
            {
                return this.userSsStatus;
            }
            set
            {
                this.userSsStatus = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int sitecountryid    
        {
            get
            {
                return this.siteCountryId;
            }
            set
            {
                this.siteCountryId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int userjuniorstatus    
        {
            get
            {
                return this.userJuniorStatus;
            }
            set
            {
                this.userJuniorStatus = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public long userbirthdate    
        {
            get
            {
                return this.userBirthDate;
            }
            set
            {
                this.userBirthDate = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int userhasshop    
        {
            get
            {
                return this.userHasShop;
            }
            set
            {
                this.userHasShop = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int usercompanyicon    
        {
            get
            {
                return this.userCompanyIcon;
            }
            set
            {
                this.userCompanyIcon = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int userisallegrostandard    
        {
            get
            {
                return this.userIsAllegroStandard;
            }
            set
            {
                this.userIsAllegroStandard = value;
                            
            }
        }
    }

    public partial class UserIncomingPaymentRefundsStruct {
        [System.Xml.Serialization.XmlIgnore]
        public long payrefundtransid    
        {
            get
            {
                return this.payRefundTransId;
            }
            set
            {
                this.payRefundTransId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public long payrefunditid    
        {
            get
            {
                return this.payRefundItId;
            }
            set
            {
                this.payRefundItId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int payrefundbuyerid    
        {
            get
            {
                return this.payRefundBuyerId;
            }
            set
            {
                this.payRefundBuyerId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public float payrefundvalue    
        {
            get
            {
                return this.payRefundValue;
            }
            set
            {
                this.payRefundValue = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string payrefundreason    
        {
            get
            {
                return this.payRefundReason;
            }
            set
            {
                this.payRefundReason = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public long payrefunddate    
        {
            get
            {
                return this.payRefundDate;
            }
            set
            {
                this.payRefundDate = value;
                            
            }
        }
    }

    public partial class UserIncomingPaymentStruct {
        [System.Xml.Serialization.XmlIgnore]
        public long paytransid    
        {
            get
            {
                return this.payTransId;
            }
            set
            {
                this.payTransId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public long paytransitid    
        {
            get
            {
                return this.payTransItId;
            }
            set
            {
                this.payTransItId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int paytransbuyerid    
        {
            get
            {
                return this.payTransBuyerId;
            }
            set
            {
                this.payTransBuyerId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string paytranstype    
        {
            get
            {
                return this.payTransType;
            }
            set
            {
                this.payTransType = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string paytransstatus    
        {
            get
            {
                return this.payTransStatus;
            }
            set
            {
                this.payTransStatus = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public float paytransamount    
        {
            get
            {
                return this.payTransAmount;
            }
            set
            {
                this.payTransAmount = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public long paytranscreatedate    
        {
            get
            {
                return this.payTransCreateDate;
            }
            set
            {
                this.payTransCreateDate = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public long paytransrecvdate    
        {
            get
            {
                return this.payTransRecvDate;
            }
            set
            {
                this.payTransRecvDate = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public float paytransprice    
        {
            get
            {
                return this.payTransPrice;
            }
            set
            {
                this.payTransPrice = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int paytranscount    
        {
            get
            {
                return this.payTransCount;
            }
            set
            {
                this.payTransCount = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public float paytranspostageamount    
        {
            get
            {
                return this.payTransPostageAmount;
            }
            set
            {
                this.payTransPostageAmount = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public PaymentDetailsStruct[] paytransdetails    
        {
            get
            {
                return this.payTransDetails;
            }
            set
            {
                this.payTransDetails = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int paytransincomplete    
        {
            get
            {
                return this.payTransIncomplete;
            }
            set
            {
                this.payTransIncomplete = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public long paytransmainid    
        {
            get
            {
                return this.payTransMainId;
            }
            set
            {
                this.payTransMainId = value;
                            
            }
        }
    }

    public partial class UserInfoStruct {
        [System.Xml.Serialization.XmlIgnore]
        public int userid    
        {
            get
            {
                return this.userId;
            }
            set
            {
                this.userId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string userlogin    
        {
            get
            {
                return this.userLogin;
            }
            set
            {
                this.userLogin = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int userrating    
        {
            get
            {
                return this.userRating;
            }
            set
            {
                this.userRating = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int usericons    
        {
            get
            {
                return this.userIcons;
            }
            set
            {
                this.userIcons = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int usercountry    
        {
            get
            {
                return this.userCountry;
            }
            set
            {
                this.userCountry = value;
                            
            }
        }
    }

    public partial class UserItemList {
        [System.Xml.Serialization.XmlIgnore]
        public long itid    
        {
            get
            {
                return this.itId;
            }
            set
            {
                this.itId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string itname    
        {
            get
            {
                return this.itName;
            }
            set
            {
                this.itName = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public float itprice    
        {
            get
            {
                return this.itPrice;
            }
            set
            {
                this.itPrice = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public float itbuynowprice    
        {
            get
            {
                return this.itBuyNowPrice;
            }
            set
            {
                this.itBuyNowPrice = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itbidcount    
        {
            get
            {
                return this.itBidCount;
            }
            set
            {
                this.itBidCount = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public long ittimeleft    
        {
            get
            {
                return this.itTimeLeft;
            }
            set
            {
                this.itTimeLeft = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itfotocount    
        {
            get
            {
                return this.itFotoCount;
            }
            set
            {
                this.itFotoCount = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itislistingthumb    
        {
            get
            {
                return this.itIsListingThumb;
            }
            set
            {
                this.itIsListingThumb = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itisboldtitle    
        {
            get
            {
                return this.itIsBoldTitle;
            }
            set
            {
                this.itIsBoldTitle = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itisbuynow    
        {
            get
            {
                return this.itIsBuyNow;
            }
            set
            {
                this.itIsBuyNow = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itcountry    
        {
            get
            {
                return this.itCountry;
            }
            set
            {
                this.itCountry = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itisescrow    
        {
            get
            {
                return this.itIsEscrow;
            }
            set
            {
                this.itIsEscrow = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public long itstartingtime    
        {
            get
            {
                return this.itStartingTime;
            }
            set
            {
                this.itStartingTime = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itisreservedprice    
        {
            get
            {
                return this.itIsReservedPrice;
            }
            set
            {
                this.itIsReservedPrice = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string itthumburl    
        {
            get
            {
                return this.itThumbUrl;
            }
            set
            {
                this.itThumbUrl = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itisallegrostandard    
        {
            get
            {
                return this.itIsAllegroStandard;
            }
            set
            {
                this.itIsAllegroStandard = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int ithasfreeshipping    
        {
            get
            {
                return this.itHasFreeShipping;
            }
            set
            {
                this.itHasFreeShipping = value;
                            
            }
        }
    }

    public partial class UserPaymentRefundsStruct {
        [System.Xml.Serialization.XmlIgnore]
        public long payrefundtransid    
        {
            get
            {
                return this.payRefundTransId;
            }
            set
            {
                this.payRefundTransId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public long payrefunditid    
        {
            get
            {
                return this.payRefundItId;
            }
            set
            {
                this.payRefundItId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int payrefundsellerid    
        {
            get
            {
                return this.payRefundSellerId;
            }
            set
            {
                this.payRefundSellerId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public float payrefundvalue    
        {
            get
            {
                return this.payRefundValue;
            }
            set
            {
                this.payRefundValue = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string payrefundreason    
        {
            get
            {
                return this.payRefundReason;
            }
            set
            {
                this.payRefundReason = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public long payrefunddate    
        {
            get
            {
                return this.payRefundDate;
            }
            set
            {
                this.payRefundDate = value;
                            
            }
        }
    }

    public partial class UserPaymentStruct {
        [System.Xml.Serialization.XmlIgnore]
        public long paytransid    
        {
            get
            {
                return this.payTransId;
            }
            set
            {
                this.payTransId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public PaymentSellersStruct[] paytranssellers    
        {
            get
            {
                return this.payTransSellers;
            }
            set
            {
                this.payTransSellers = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string paytranstype    
        {
            get
            {
                return this.payTransType;
            }
            set
            {
                this.payTransType = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string paytransstatus    
        {
            get
            {
                return this.payTransStatus;
            }
            set
            {
                this.payTransStatus = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public float paytransamount    
        {
            get
            {
                return this.payTransAmount;
            }
            set
            {
                this.payTransAmount = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public long paytranscreatedate    
        {
            get
            {
                return this.payTransCreateDate;
            }
            set
            {
                this.payTransCreateDate = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public float paytransprice    
        {
            get
            {
                return this.payTransPrice;
            }
            set
            {
                this.payTransPrice = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public float paytranspostageamount    
        {
            get
            {
                return this.payTransPostageAmount;
            }
            set
            {
                this.payTransPostageAmount = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int paytransincomplete    
        {
            get
            {
                return this.payTransIncomplete;
            }
            set
            {
                this.payTransIncomplete = value;
                            
            }
        }
    }

    public partial class UserPayoutStruct {
        [System.Xml.Serialization.XmlIgnore]
        public long paytransid    
        {
            get
            {
                return this.payTransId;
            }
            set
            {
                this.payTransId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string paytransstatus    
        {
            get
            {
                return this.payTransStatus;
            }
            set
            {
                this.payTransStatus = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public float paytransamount    
        {
            get
            {
                return this.payTransAmount;
            }
            set
            {
                this.payTransAmount = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public long paytranscreatedate    
        {
            get
            {
                return this.payTransCreateDate;
            }
            set
            {
                this.payTransCreateDate = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public long paytransrecvdate    
        {
            get
            {
                return this.payTransRecvDate;
            }
            set
            {
                this.payTransRecvDate = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public long paytranscanceldate    
        {
            get
            {
                return this.payTransCancelDate;
            }
            set
            {
                this.payTransCancelDate = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string paytransreport    
        {
            get
            {
                return this.payTransReport;
            }
            set
            {
                this.payTransReport = value;
                            
            }
        }
    }

    public partial class UserPostBuyDataStruct {
        [System.Xml.Serialization.XmlIgnore]
        public UserDataStruct userdata    
        {
            get
            {
                return this.userData;
            }
            set
            {
                this.userData = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public UserSentToDataStruct usersenttodata    
        {
            get
            {
                return this.userSentToData;
            }
            set
            {
                this.userSentToData = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string[] userbankaccounts    
        {
            get
            {
                return this.userBankAccounts;
            }
            set
            {
                this.userBankAccounts = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public CompanySecondAddressStruct companysecondaddress    
        {
            get
            {
                return this.companySecondAddress;
            }
            set
            {
                this.companySecondAddress = value;
                            
            }
        }
    }

    public partial class UserSentToDataStruct {
        [System.Xml.Serialization.XmlIgnore]
        public long userid    
        {
            get
            {
                return this.userId;
            }
            set
            {
                this.userId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string userfirstname    
        {
            get
            {
                return this.userFirstName;
            }
            set
            {
                this.userFirstName = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string userlastname    
        {
            get
            {
                return this.userLastName;
            }
            set
            {
                this.userLastName = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string usercompany    
        {
            get
            {
                return this.userCompany;
            }
            set
            {
                this.userCompany = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int usercountryid    
        {
            get
            {
                return this.userCountryId;
            }
            set
            {
                this.userCountryId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string userpostcode    
        {
            get
            {
                return this.userPostcode;
            }
            set
            {
                this.userPostcode = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string usercity    
        {
            get
            {
                return this.userCity;
            }
            set
            {
                this.userCity = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string useraddress    
        {
            get
            {
                return this.userAddress;
            }
            set
            {
                this.userAddress = value;
                            
            }
        }
    }

    public partial class WaitFeedbackStruct {
        [System.Xml.Serialization.XmlIgnore]
        public long feitemid    
        {
            get
            {
                return this.feItemId;
            }
            set
            {
                this.feItemId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string feitemname    
        {
            get
            {
                return this.feItemName;
            }
            set
            {
                this.feItemName = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int fetouserid    
        {
            get
            {
                return this.feToUserId;
            }
            set
            {
                this.feToUserId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int feop    
        {
            get
            {
                return this.feOp;
            }
            set
            {
                this.feOp = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string feanscommenttype    
        {
            get
            {
                return this.feAnsCommentType;
            }
            set
            {
                this.feAnsCommentType = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int fepossibilitytoadd    
        {
            get
            {
                return this.fePossibilityToAdd;
            }
            set
            {
                this.fePossibilityToAdd = value;
                            
            }
        }
    }

    public partial class WatchItemStruct {
        [System.Xml.Serialization.XmlIgnore]
        public long itemid    
        {
            get
            {
                return this.itemId;
            }
            set
            {
                this.itemId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string itemtitle    
        {
            get
            {
                return this.itemTitle;
            }
            set
            {
                this.itemTitle = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string itemthumbnailurl    
        {
            get
            {
                return this.itemThumbnailUrl;
            }
            set
            {
                this.itemThumbnailUrl = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public ItemPriceStruct[] itemprice    
        {
            get
            {
                return this.itemPrice;
            }
            set
            {
                this.itemPrice = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itemleftquantity    
        {
            get
            {
                return this.itemLeftQuantity;
            }
            set
            {
                this.itemLeftQuantity = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itemquantitytype    
        {
            get
            {
                return this.itemQuantityType;
            }
            set
            {
                this.itemQuantityType = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string itemendtime    
        {
            get
            {
                return this.itemEndTime;
            }
            set
            {
                this.itemEndTime = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string itemendtimeleft    
        {
            get
            {
                return this.itemEndTimeLeft;
            }
            set
            {
                this.itemEndTimeLeft = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public UserInfoStruct itemseller    
        {
            get
            {
                return this.itemSeller;
            }
            set
            {
                this.itemSeller = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itembidderscounter    
        {
            get
            {
                return this.itemBiddersCounter;
            }
            set
            {
                this.itemBiddersCounter = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public UserInfoStruct itemhighestbidder    
        {
            get
            {
                return this.itemHighestBidder;
            }
            set
            {
                this.itemHighestBidder = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itemcategoryid    
        {
            get
            {
                return this.itemCategoryId;
            }
            set
            {
                this.itemCategoryId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itemviewscounter    
        {
            get
            {
                return this.itemViewsCounter;
            }
            set
            {
                this.itemViewsCounter = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string itemnote    
        {
            get
            {
                return this.itemNote;
            }
            set
            {
                this.itemNote = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itemspecialinfo    
        {
            get
            {
                return this.itemSpecialInfo;
            }
            set
            {
                this.itemSpecialInfo = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itemshopinfo    
        {
            get
            {
                return this.itemShopInfo;
            }
            set
            {
                this.itemShopInfo = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public long itemproductinfo    
        {
            get
            {
                return this.itemProductInfo;
            }
            set
            {
                this.itemProductInfo = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itempayuinfo    
        {
            get
            {
                return this.itemPayuInfo;
            }
            set
            {
                this.itemPayuInfo = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public ItemReminderStruct[] itemreminder    
        {
            get
            {
                return this.itemReminder;
            }
            set
            {
                this.itemReminder = value;
                            
            }
        }
    }

    public partial class WatchListInfoStruct {
        [System.Xml.Serialization.XmlIgnore]
        public long[] itemsadded    
        {
            get
            {
                return this.itemsAdded;
            }
            set
            {
                this.itemsAdded = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public ItemsNotAddedStruct[] itemsnotadded    
        {
            get
            {
                return this.itemsNotAdded;
            }
            set
            {
                this.itemsNotAdded = value;
                            
            }
        }
    }

    public partial class WatchedItemStruct {
        [System.Xml.Serialization.XmlIgnore]
        public long itemid    
        {
            get
            {
                return this.itemId;
            }
            set
            {
                this.itemId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string itemtitle    
        {
            get
            {
                return this.itemTitle;
            }
            set
            {
                this.itemTitle = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string itemthumbnailurl    
        {
            get
            {
                return this.itemThumbnailUrl;
            }
            set
            {
                this.itemThumbnailUrl = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public ItemPriceStruct[] itemprice    
        {
            get
            {
                return this.itemPrice;
            }
            set
            {
                this.itemPrice = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itemleftquantity    
        {
            get
            {
                return this.itemLeftQuantity;
            }
            set
            {
                this.itemLeftQuantity = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itemquantitytype    
        {
            get
            {
                return this.itemQuantityType;
            }
            set
            {
                this.itemQuantityType = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public long itemendtime    
        {
            get
            {
                return this.itemEndTime;
            }
            set
            {
                this.itemEndTime = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public UserInfoStruct itemseller    
        {
            get
            {
                return this.itemSeller;
            }
            set
            {
                this.itemSeller = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itembidderscounter    
        {
            get
            {
                return this.itemBiddersCounter;
            }
            set
            {
                this.itemBiddersCounter = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public UserInfoStruct itemhighestbidder    
        {
            get
            {
                return this.itemHighestBidder;
            }
            set
            {
                this.itemHighestBidder = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itemcategoryid    
        {
            get
            {
                return this.itemCategoryId;
            }
            set
            {
                this.itemCategoryId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itemviewscounter    
        {
            get
            {
                return this.itemViewsCounter;
            }
            set
            {
                this.itemViewsCounter = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string itemnote    
        {
            get
            {
                return this.itemNote;
            }
            set
            {
                this.itemNote = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itemspecialinfo    
        {
            get
            {
                return this.itemSpecialInfo;
            }
            set
            {
                this.itemSpecialInfo = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itemshopinfo    
        {
            get
            {
                return this.itemShopInfo;
            }
            set
            {
                this.itemShopInfo = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public long itemproductinfo    
        {
            get
            {
                return this.itemProductInfo;
            }
            set
            {
                this.itemProductInfo = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itempayuinfo    
        {
            get
            {
                return this.itemPayuInfo;
            }
            set
            {
                this.itemPayuInfo = value;
                            
            }
        }
    }

    public partial class WonItemStruct {
        [System.Xml.Serialization.XmlIgnore]
        public long itemid    
        {
            get
            {
                return this.itemId;
            }
            set
            {
                this.itemId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string itemtitle    
        {
            get
            {
                return this.itemTitle;
            }
            set
            {
                this.itemTitle = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string itemthumbnailurl    
        {
            get
            {
                return this.itemThumbnailUrl;
            }
            set
            {
                this.itemThumbnailUrl = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public ItemPriceStruct[] itemprice    
        {
            get
            {
                return this.itemPrice;
            }
            set
            {
                this.itemPrice = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itemboughtquantity    
        {
            get
            {
                return this.itemBoughtQuantity;
            }
            set
            {
                this.itemBoughtQuantity = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itemleftquantity    
        {
            get
            {
                return this.itemLeftQuantity;
            }
            set
            {
                this.itemLeftQuantity = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itemquantitytype    
        {
            get
            {
                return this.itemQuantityType;
            }
            set
            {
                this.itemQuantityType = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public long itemendtime    
        {
            get
            {
                return this.itemEndTime;
            }
            set
            {
                this.itemEndTime = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string itemendtimeleft    
        {
            get
            {
                return this.itemEndTimeLeft;
            }
            set
            {
                this.itemEndTimeLeft = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public UserInfoStruct itemseller    
        {
            get
            {
                return this.itemSeller;
            }
            set
            {
                this.itemSeller = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itembidderscounter    
        {
            get
            {
                return this.itemBiddersCounter;
            }
            set
            {
                this.itemBiddersCounter = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itemcategoryid    
        {
            get
            {
                return this.itemCategoryId;
            }
            set
            {
                this.itemCategoryId = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itemviewscounter    
        {
            get
            {
                return this.itemViewsCounter;
            }
            set
            {
                this.itemViewsCounter = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string itemnote    
        {
            get
            {
                return this.itemNote;
            }
            set
            {
                this.itemNote = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itemspecialinfo    
        {
            get
            {
                return this.itemSpecialInfo;
            }
            set
            {
                this.itemSpecialInfo = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itemshopinfo    
        {
            get
            {
                return this.itemShopInfo;
            }
            set
            {
                this.itemShopInfo = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public long itemproductinfo    
        {
            get
            {
                return this.itemProductInfo;
            }
            set
            {
                this.itemProductInfo = value;
                            
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int itempayuinfo    
        {
            get
            {
                return this.itemPayuInfo;
            }
            set
            {
                this.itemPayuInfo = value;
                            
            }
        }
    }


}

