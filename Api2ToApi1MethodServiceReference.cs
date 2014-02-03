namespace allegrowebapi
{
    public partial class servicePortClient
    {

        public long[] doAddDescToItems(out long[] arrayItemsDescToLong, out long[] arrayItemsNotFound, string sessionHandle, long[] itemsIdArray, string itDescription)
        {
            return doAddDescToItems(sessionHandle, itemsIdArray, itDescription, out arrayItemsDescToLong, out arrayItemsNotFound);
        }
        public int doCancelBidItem(out int[] cancelledBids, out int[] notCancelledBids, string sessionHandle, long cancelItemId, int[] cancelBidsArray, string cancelBidsReason, long cancelAddToBlackList)
        {
            return doCancelBidItem(sessionHandle, cancelItemId, cancelBidsArray, cancelBidsReason, cancelAddToBlackList, out cancelledBids, out notCancelledBids);
        }
        public string doChangeQuantityItem(out int itemQuantityLeft, out int itemQuantitySold, string sessionHandle, ref long itemId, int newItemQuantity)
        {
            return doChangeQuantityItem(sessionHandle, ref itemId, newItemQuantity, out itemQuantityLeft, out itemQuantitySold);
        }
        public string doCheckNewAuctionExt(out string itemPriceDesc, out int itemIsAllegroStandard, string sessionHandle, FieldsValue[] fields)
        {
            return doCheckNewAuctionExt(sessionHandle, fields, out itemPriceDesc, out itemIsAllegroStandard);
        }
        public long[] doFinishItems(out FinishFailureStruct[] finishItemsFailed, string sessionHandle, FinishItemsStruct[] finishItemsList)
        {
            return doFinishItems(sessionHandle, finishItemsList, out finishItemsFailed);
        }
        public CatInfoType[] doGetCatsData(out long verKey, out string verStr, int countryId, long localVersion, string webapiKey)
        {
            return doGetCatsData(countryId, localVersion, webapiKey, out verKey, out verStr);
        }
        public int doGetCatsDataCount(out long verKey, out string verStr, int countryId, long localVersion, string webapiKey)
        {
            return doGetCatsDataCount(countryId, localVersion, webapiKey, out verKey, out verStr);
        }
        public CatInfoType[] doGetCatsDataLimit(out long verKey, out string verStr, int countryId, long localVersion, string webapiKey, int offset, int packageElement)
        {
            return doGetCatsDataLimit(countryId, localVersion, webapiKey, offset, packageElement, out verKey, out verStr);
        }
        public FeedbackList[] doGetFeedback(out int feedbackCount, string sessionHandle, int feedbackFrom, int feedbackTo, int feedbackOffset, string feedbackKindList)
        {
            return doGetFeedback(sessionHandle, feedbackFrom, feedbackTo, feedbackOffset, feedbackKindList, out feedbackCount);
        }
        public ItemInfoStruct[] doGetItemsInfo(out long[] arrayItemsNotFound, out long[] arrayItemsAdminKilled, string sessionHandle, long[] itemsIdArray, int getDesc, int getImageUrl, int getAttribs, int getPostageOptions, int getCompanyInfo, int getProductInfo)
        {
            return doGetItemsInfo(sessionHandle, itemsIdArray, getDesc, getImageUrl, getAttribs, getPostageOptions, getCompanyInfo, getProductInfo, out arrayItemsNotFound, out arrayItemsAdminKilled);
        }
        public int doGetMyBidItems(out BidItemStruct[] bidItemsList, string sessionId, SortOptionsStruct sortOptions, string searchValue, int categoryId, long[] itemIds, int pageSize, int pageNumber)
        {
            return doGetMyBidItems(sessionId, sortOptions, searchValue, categoryId, itemIds, pageSize, pageNumber, out bidItemsList);
        }
        public UserDataStruct doGetMyData(out InvoiceDataStruct invoiceData, out CompanyExtraDataStruct companyExtraData, out CompanySecondAddressStruct companySecondAddress, out PharmacyDataStruct pharmacyData, out AlcoholDataStruct alcoholData, out RelatedPersonsStruct relatedPersons, string sessionHandle)
        {
            return doGetMyData(sessionHandle, out invoiceData, out companyExtraData, out companySecondAddress, out pharmacyData, out alcoholData, out relatedPersons);
        }
        public int doGetMyFutureItems(out FutureItemStruct[] futureItemsList, string sessionId, SortOptionsStruct sortOptions, FutureFilterOptionsStruct filterOptions, int categoryId, long[] itemIds, int pageSize, int pageNumber)
        {
            return doGetMyFutureItems(sessionId, sortOptions, filterOptions, categoryId, itemIds, pageSize, pageNumber, out futureItemsList);
        }
        public int doGetMyNotSoldItems(out NotSoldItemStruct[] notSoldItemsList, string sessionId, SortOptionsStruct sortOptions, NotSoldFilterOptionsStruct filterOptions, string searchValue, int categoryId, long[] itemIds, int pageSize, int pageNumber)
        {
            return doGetMyNotSoldItems(sessionId, sortOptions, filterOptions, searchValue, categoryId, itemIds, pageSize, pageNumber, out notSoldItemsList);
        }
        public int doGetMyNotWonItems(out NotWonItemStruct[] notWonItemsList, string sessionId, SortOptionsStruct sortOptions, string searchValue, int categoryId, long[] itemIds, int pageSize, int pageNumber)
        {
            return doGetMyNotWonItems(sessionId, sortOptions, searchValue, categoryId, itemIds, pageSize, pageNumber, out notWonItemsList);
        }
        public int doGetMySellItems(out SellItemStruct[] sellItemsList, string sessionId, SortOptionsStruct sortOptions, SellFilterOptionsStruct filterOptions, string searchValue, int categoryId, long[] itemIds, int pageSize, int pageNumber)
        {
            return doGetMySellItems(sessionId, sortOptions, filterOptions, searchValue, categoryId, itemIds, pageSize, pageNumber, out sellItemsList);
        }
        public int doGetMySellRating(out SellRatingAverageStruct[] sellRatingAverage, out SellRatingDetailStruct[] sellRatingDetails, out SellRatingAveragePerMonthStruct[] sellRatingStatsPerMonth, string sessionHandle)
        {
            return doGetMySellRating(sessionHandle, out sellRatingAverage, out sellRatingDetails, out sellRatingStatsPerMonth);
        }
        public int doGetMySoldItems(out SoldItemStruct[] soldItemsList, string sessionId, SortOptionsStruct sortOptions, SoldFilterOptionsStruct filterOptions, string searchValue, int categoryId, long[] itemIds, int pageSize, int pageNumber)
        {
            return doGetMySoldItems(sessionId, sortOptions, filterOptions, searchValue, categoryId, itemIds, pageSize, pageNumber, out soldItemsList);
        }
        public int doGetMyWatchItems(out WatchItemStruct[] watchItemsList, string sessionId, SortOptionsStruct sortOptions, string searchValue, int categoryId, long[] itemIds, int pageSize, int pageNumber)
        {
            return doGetMyWatchItems(sessionId, sortOptions, searchValue, categoryId, itemIds, pageSize, pageNumber, out watchItemsList);
        }
        public int doGetMyWatchedItems(out WatchedItemStruct[] watchedItemsList, string sessionId, SortOptionsStruct sortOptions, string searchValue, int categoryId, long[] itemIds, int pageSize, int pageNumber)
        {
            return doGetMyWatchedItems(sessionId, sortOptions, searchValue, categoryId, itemIds, pageSize, pageNumber, out watchedItemsList);
        }
        public int doGetMyWonItems(out WonItemStruct[] wonItemsList, string sessionId, SortOptionsStruct sortOptions, string searchValue, int categoryId, long[] itemIds, int pageSize, int pageNumber)
        {
            return doGetMyWonItems(sessionId, sortOptions, searchValue, categoryId, itemIds, pageSize, pageNumber, out wonItemsList);
        }
        public int doGetRefundTransactions(out RefundFormDataStruct[] refundFormsList, string sessionHandle, int offset, int limit)
        {
            return doGetRefundTransactions(sessionHandle, offset, limit, out refundFormsList);
        }
        public int doGetRefundsDeals(out RefundsDealsListType[] dealsList, out FiltersListType[] filtersList, string sessionId, FilterOptionsType[] filterOptions, string sortOrder, int resultSize, int resultOffset)
        {
            return doGetRefundsDeals(sessionId, filterOptions, sortOrder, resultSize, resultOffset, out dealsList, out filtersList);
        }
        public int doGetRefundsList(out RefundListType[] refundsList, out FiltersListType[] filtersList, string sessionId, FilterOptionsType[] filterOptions, int resultSize, int resultOffset)
        {
            return doGetRefundsList(sessionId, filterOptions, resultSize, resultOffset, out refundsList, out filtersList);
        }
        public SellFormType[] doGetSellFormAttribs(out long verKey, out string verStr, int countryId, string webapiKey, long localVersion, int catId)
        {
            return doGetSellFormAttribs(countryId, webapiKey, localVersion, catId, out verKey, out verStr);
        }
        public SellFormType[] doGetSellFormFields(out long verKey, out string verStr, int countryCode, long localVersion, string webapiKey)
        {
            return doGetSellFormFields(countryCode, localVersion, webapiKey, out verKey, out verStr);
        }
        public SellFormType[] doGetSellFormFieldsExt(out long verKey, out string verStr, int countryCode, long localVersion, string webapiKey)
        {
            return doGetSellFormFieldsExt(countryCode, localVersion, webapiKey, out verKey, out verStr);
        }
        public SellFormType[] doGetSellFormFieldsExtLimit(out long verKey, out string verStr, out int formFieldsCount, int countryCode, long localVersion, string webapiKey, int offset, int packageElement)
        {
            return doGetSellFormFieldsExtLimit(countryCode, localVersion, webapiKey, offset, packageElement, out verKey, out verStr, out formFieldsCount);
        }
        public SellFormType[] doGetSellFormFieldsLimit(out long verKey, out string verStr, out int formFieldsCount, int countryCode, long localVersion, string webapiKey, int offset, int packageElement)
        {
            return doGetSellFormFieldsLimit(countryCode, localVersion, webapiKey, offset, packageElement, out verKey, out verStr, out formFieldsCount);
        }
        public string doGetSessionHandleForWidget(out long serverTime, string webapiKey, int countryCode)
        {
            return doGetSessionHandleForWidget(webapiKey, countryCode, out serverTime);
        }
        public ShipmentDataStruct[] doGetShipmentData(out long localVersion, int countryId, string webapiKey)
        {
            return doGetShipmentData(countryId, webapiKey, out localVersion);
        }
        public SiteFlagInfoType[] doGetSitesFlagInfo(out long verKey, out string verStr, int countryCode, string webapiKey)
        {
            return doGetSitesFlagInfo(countryCode, webapiKey, out verKey, out verStr);
        }
        public SiteInfoType[] doGetSitesInfo(out long verKey, out string verStr, int countryCode, string webapiKey)
        {
            return doGetSitesInfo(countryCode, webapiKey, out verKey, out verStr);
        }
        public UserItemList[] doGetUserItems(out int userItemCount, int userId, string webapiKey, int countryId, int offset, int limit)
        {
            return doGetUserItems(userId, webapiKey, countryId, offset, limit, out userItemCount);
        }
        public string doLogin(out long userId, out long serverTime, string userLogin, string userPassword, int countryCode, string webapiKey, long localVersion)
        {
            return doLogin(userLogin, userPassword, countryCode, webapiKey, localVersion, out userId, out serverTime);
        }
        public string doLoginEnc(out long userId, out long serverTime, string userLogin, string userHashPassword, int countryCode, string webapiKey, long localVersion)
        {
            return doLoginEnc(userLogin, userHashPassword, countryCode, webapiKey, localVersion, out userId, out serverTime);
        }
        public ItemBilling[] doMyBillingItem(out ItemBilling[] endingFees, string sessionHandle, long itemId, string option)
        {
            return doMyBillingItem(sessionHandle, itemId, option, out endingFees);
        }
        public long doNewAuctionExt(out string itemInfo, out int itemIsAllegroStandard, string sessionHandle, FieldsValue[] fields, int itemTemplateId, int localId, ItemTemplateCreateStruct itemTemplateCreate)
        {
            return doNewAuctionExt(sessionHandle, fields, itemTemplateId, localId, itemTemplateCreate, out itemInfo, out itemIsAllegroStandard);
        }
        public string doQuerySysStatus(out long verKey, int sysvar, int countryId, string webapiKey)
        {
            return doQuerySysStatus(sysvar, countryId, webapiKey, out verKey);
        }
        public int doSearch(out int searchCountFeatured, out SearchResponseType[] searchArray, out string[] searchExcludedWords, out CategoriesStruct[] searchCategories, string sessionHandle, SearchOptType searchQuery)
        {
            return doSearch(sessionHandle, searchQuery, out searchCountFeatured, out searchArray, out searchExcludedWords, out searchCategories);
        }
        public StructSellAgain[] doSellSomeAgain(out StructSellFailed[] itemsSellFailed, out long[] itemsSellNotFound, string sessionHandle, long[] sellItemsArray, long sellStartingTime, int sellAuctionDuration, int sellOptions, int[] localIds)
        {
            return doSellSomeAgain(sessionHandle, sellItemsArray, sellStartingTime, sellAuctionDuration, sellOptions, localIds, out itemsSellFailed, out itemsSellNotFound);
        }
        public StructSellAgain[] doSellSomeAgainInShop(out StructSellFailed[] itemsSellFailed, out long[] itemsSellNotFound, string sessionHandle, long[] sellItemsArray, long sellStartingTime, int sellShopDuration, int sellShopOptions, int sellProlongOptions, long sellShopCategory, int[] localIds)
        {
            return doSellSomeAgainInShop(sessionHandle, sellItemsArray, sellStartingTime, sellShopDuration, sellShopOptions, sellProlongOptions, sellShopCategory, localIds, out itemsSellFailed, out itemsSellNotFound);
        }
        public InfoCatList[] doShowCat(out InfoCatList[] catChildArray, out InfoCatList[] catSisterArray, out int catItemsCount, out int catItemsCountFeatured, out SearchResponseType[] catItemsArray, string sessionHandle, int catId, int catItemState, int catItemOption, DurationTimeInfo catItemDurationOption, FieldsValue[] catAttribFields, int catSortOptions, PriceCatInfo catItemsPrice, int catItemsOffset, int catItemsLimit, int catOrderFulfillmentTime)
        {
            return doShowCat(sessionHandle, catId, catItemState, catItemOption, catItemDurationOption, catAttribFields, catSortOptions, catItemsPrice, catItemsOffset, catItemsLimit, catOrderFulfillmentTime, out catChildArray, out catSisterArray, out catItemsCount, out catItemsCountFeatured, out catItemsArray);
        }
        public ItemInfoExt doShowItemInfoExt(out ItemCatList[] itemCatPath, out ItemImageList[] itemImgList, out AttribStruct[] itemAttribList, out PostageStruct[] itemPostageOptions, out ItemPaymentOptions itemPaymentOptions, out CompanyInfoStruct itemCompanyInfo, out ProductStruct itemProductInfo, string sessionHandle, long itemId, int getDesc, int getImageUrl, int getAttribs, int getPostageOptions, int getCompanyInfo, int getProductInfo)
        {
            return doShowItemInfoExt(sessionHandle, itemId, getDesc, getImageUrl, getAttribs, getPostageOptions, getCompanyInfo, getProductInfo, out itemCatPath, out itemImgList, out itemAttribList, out itemPostageOptions, out itemPaymentOptions, out itemCompanyInfo, out itemProductInfo);
        }
        public int doShowUser(out long userCreateDate, out long userLoginDate, out int userRating, out int userIsNewUser, out int userNotActivated, out int userClosed, out int userBlocked, out int userTerminated, out int userHasPage, out int userIsSseller, out int userIsEco, out ShowUserFeedbacks userPositiveFeedback, out ShowUserFeedbacks userNegativeFeedback, out ShowUserFeedbacks userNeutralFeedback, out int userJuniorStatus, out int userHasShop, out int userCompanyIcon, out int userSellRatingCount, out SellRatingAverageStruct[] userSellRatingAverage, out int userIsAllegroStandard, out int userIsB2cSeller, string webapiKey, int countryId, ref long userId, ref string userLogin)
        {
            return doShowUser(webapiKey, countryId, ref userId, ref userLogin, out userCreateDate, out userLoginDate, out userRating, out userIsNewUser, out userNotActivated, out userClosed, out userBlocked, out userTerminated, out userHasPage, out userIsSseller, out userIsEco, out userPositiveFeedback, out userNegativeFeedback, out userNeutralFeedback, out userJuniorStatus, out userHasShop, out userCompanyIcon, out userSellRatingCount, out userSellRatingAverage, out userIsAllegroStandard, out userIsB2cSeller);
        }
        public string doShowUserPage(out string userPagePharmacyPermit, out string userPageAlcoholPermit, string webapiKey, int countryId, long userId)
        {
            return doShowUserPage(webapiKey, countryId, userId, out userPagePharmacyPermit, out userPageAlcoholPermit);
        }
        public long doVerifyItem(out int itemListed, out long itemStartingTime, string sessionHandle, int localId)
        {
            return doVerifyItem(sessionHandle, localId, out itemListed, out itemStartingTime);
        }

    }
}

