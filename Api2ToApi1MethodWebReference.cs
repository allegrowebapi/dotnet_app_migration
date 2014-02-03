namespace allegrowebapi
{
    public partial class serviceService
    {

        public string doBidItem(string sessionHandle, long bidItId, float bidUserPrice, long bidQuantity, long bidBuyNow, PharmacyRecipientDataStruct pharmacyRecipientData)
        {
            return doBidItem(sessionHandle, bidItId, bidUserPrice, bidQuantity, bidBuyNow, true, pharmacyRecipientData);
        }
        public int doCancelBidItem(string sessionHandle, long cancelItemId, int[] cancelBidsArray, string cancelBidsReason, long cancelAddToBlackList, out int[] cancelledBids, out int[] notCancelledBids)
        {
            return doCancelBidItem(sessionHandle, cancelItemId, cancelBidsArray, cancelBidsReason, cancelAddToBlackList, true, out cancelledBids, out notCancelledBids);
        }
        public ChangedItemStruct doChangeItemFields(string sessionId, long itemId, FieldsValue[] fieldsToModify, int[] fieldsToRemove, int previewOnly)
        {
            return doChangeItemFields(sessionId, itemId, fieldsToModify, fieldsToRemove, previewOnly, true);
        }
        public string doChangePriceItem(string sessionHandle, ref long itemId, float newStartingPrice, float newReservePrice, float newBuyNowPrice)
        {
            return doChangePriceItem(sessionHandle, ref itemId, newStartingPrice, true, newReservePrice, true, newBuyNowPrice, true);
        }
        public int doFeedback(string sessionHandle, long feItemId, int feUseCommentTemplate, int feToUserId, string feComment, string feCommentType, int feOp, SellRatingEstimationStruct[] feRating)
        {
            return doFeedback(sessionHandle, feItemId, feUseCommentTemplate, true, feToUserId, feComment, feCommentType, feOp, feRating);
        }
        public int doFinishItem(string sessionHandle, long finishItemId, int finishCancelAllBids, string finishCancelReason)
        {
            return doFinishItem(sessionHandle, finishItemId, finishCancelAllBids, true, finishCancelReason);
        }
        public CatInfoType[] doGetCatsData(int countryId, long localVersion, string webapiKey, out long verKey, out string verStr)
        {
            return doGetCatsData(countryId, localVersion, true, webapiKey, out verKey, out verStr);
        }
        public int doGetCatsDataCount(int countryId, long localVersion, string webapiKey, out long verKey, out string verStr)
        {
            return doGetCatsDataCount(countryId, localVersion, true, webapiKey, out verKey, out verStr);
        }
        public CatInfoType[] doGetCatsDataLimit(int countryId, long localVersion, string webapiKey, int offset, int packageElement, out long verKey, out string verStr)
        {
            return doGetCatsDataLimit(countryId, localVersion, true, webapiKey, offset, true, packageElement, true, out verKey, out verStr);
        }
        public FeedbackList[] doGetFeedback(string sessionHandle, int feedbackFrom, int feedbackTo, int feedbackOffset, string feedbackKindList, out int feedbackCount)
        {
            return doGetFeedback(sessionHandle, feedbackFrom, feedbackTo, feedbackOffset, true, feedbackKindList, out feedbackCount);
        }
        public FilledPostBuyFormsStruct doGetFilledPostBuyForms(string sessionId, int paymentType, int userRole, long fillingTimeFrom, long fillingTimeTo)
        {
            return doGetFilledPostBuyForms(sessionId, paymentType, true, userRole, fillingTimeFrom, true, fillingTimeTo, true);
        }
        public ItemInfoStruct[] doGetItemsInfo(string sessionHandle, long[] itemsIdArray, int getDesc, int getImageUrl, int getAttribs, int getPostageOptions, int getCompanyInfo, int getProductInfo, out long[] arrayItemsNotFound, out long[] arrayItemsAdminKilled)
        {
            return doGetItemsInfo(sessionHandle, itemsIdArray, getDesc, true, getImageUrl, true, getAttribs, true, getPostageOptions, true, getCompanyInfo, true, getProductInfo, true, out arrayItemsNotFound, out arrayItemsAdminKilled);
        }
        public int doGetMyBidItems(string sessionId, SortOptionsStruct sortOptions, string searchValue, int categoryId, long[] itemIds, int pageSize, int pageNumber, out BidItemStruct[] bidItemsList)
        {
            return doGetMyBidItems(sessionId, sortOptions, searchValue, categoryId, true, itemIds, pageSize, true, pageNumber, true, out bidItemsList);
        }
        public int doGetMyFutureItems(string sessionId, SortOptionsStruct sortOptions, FutureFilterOptionsStruct filterOptions, int categoryId, long[] itemIds, int pageSize, int pageNumber, out FutureItemStruct[] futureItemsList)
        {
            return doGetMyFutureItems(sessionId, sortOptions, filterOptions, categoryId, true, itemIds, pageSize, true, pageNumber, true, out futureItemsList);
        }
        public UserIncomingPaymentStruct[] doGetMyIncomingPayments(string sessionHandle, int buyerId, long itemId, long transRecvDateFrom, long transRecvDateTo, int transPageLimit, int transOffset)
        {
            return doGetMyIncomingPayments(sessionHandle, buyerId, true, itemId, true, transRecvDateFrom, true, transRecvDateTo, true, transPageLimit, true, transOffset, true);
        }
        public UserIncomingPaymentRefundsStruct[] doGetMyIncomingPaymentsRefunds(string sessionHandle, int buyerId, long itemId, int limit, int offset)
        {
            return doGetMyIncomingPaymentsRefunds(sessionHandle, buyerId, true, itemId, true, limit, true, offset, true);
        }
        public int doGetMyNotSoldItems(string sessionId, SortOptionsStruct sortOptions, NotSoldFilterOptionsStruct filterOptions, string searchValue, int categoryId, long[] itemIds, int pageSize, int pageNumber, out NotSoldItemStruct[] notSoldItemsList)
        {
            return doGetMyNotSoldItems(sessionId, sortOptions, filterOptions, searchValue, categoryId, true, itemIds, pageSize, true, pageNumber, true, out notSoldItemsList);
        }
        public int doGetMyNotWonItems(string sessionId, SortOptionsStruct sortOptions, string searchValue, int categoryId, long[] itemIds, int pageSize, int pageNumber, out NotWonItemStruct[] notWonItemsList)
        {
            return doGetMyNotWonItems(sessionId, sortOptions, searchValue, categoryId, true, itemIds, pageSize, true, pageNumber, true, out notWonItemsList);
        }
        public UserPaymentStruct[] doGetMyPayments(string sessionId, int sellerId, long itemId, long paymentTimeFrom, long paymentTimeTo, int pageSize, int pageNumber)
        {
            return doGetMyPayments(sessionId, sellerId, true, itemId, true, paymentTimeFrom, true, paymentTimeTo, true, pageSize, true, pageNumber, true);
        }
        public UserPaymentRefundsStruct[] doGetMyPaymentsRefunds(string sessionHandle, int sellerId, long itemId, int limit, int offset)
        {
            return doGetMyPaymentsRefunds(sessionHandle, sellerId, true, itemId, true, limit, true, offset, true);
        }
        public UserPayoutStruct[] doGetMyPayouts(string sessionHandle, long transCreateDateFrom, long transCreateDateTo, int transPageLimit, int transOffset)
        {
            return doGetMyPayouts(sessionHandle, transCreateDateFrom, true, transCreateDateTo, true, transPageLimit, true, transOffset, true);
        }
        public int doGetMySellItems(string sessionId, SortOptionsStruct sortOptions, SellFilterOptionsStruct filterOptions, string searchValue, int categoryId, long[] itemIds, int pageSize, int pageNumber, out SellItemStruct[] sellItemsList)
        {
            return doGetMySellItems(sessionId, sortOptions, filterOptions, searchValue, categoryId, true, itemIds, pageSize, true, pageNumber, true, out sellItemsList);
        }
        public int doGetMySoldItems(string sessionId, SortOptionsStruct sortOptions, SoldFilterOptionsStruct filterOptions, string searchValue, int categoryId, long[] itemIds, int pageSize, int pageNumber, out SoldItemStruct[] soldItemsList)
        {
            return doGetMySoldItems(sessionId, sortOptions, filterOptions, searchValue, categoryId, true, itemIds, pageSize, true, pageNumber, true, out soldItemsList);
        }
        public int doGetMyWatchItems(string sessionId, SortOptionsStruct sortOptions, string searchValue, int categoryId, long[] itemIds, int pageSize, int pageNumber, out WatchItemStruct[] watchItemsList)
        {
            return doGetMyWatchItems(sessionId, sortOptions, searchValue, categoryId, true, itemIds, pageSize, true, pageNumber, true, out watchItemsList);
        }
        public int doGetMyWatchedItems(string sessionId, SortOptionsStruct sortOptions, string searchValue, int categoryId, long[] itemIds, int pageSize, int pageNumber, out WatchedItemStruct[] watchedItemsList)
        {
            return doGetMyWatchedItems(sessionId, sortOptions, searchValue, categoryId, true, itemIds, pageSize, true, pageNumber, true, out watchedItemsList);
        }
        public int doGetMyWonItems(string sessionId, SortOptionsStruct sortOptions, string searchValue, int categoryId, long[] itemIds, int pageSize, int pageNumber, out WonItemStruct[] wonItemsList)
        {
            return doGetMyWonItems(sessionId, sortOptions, searchValue, categoryId, true, itemIds, pageSize, true, pageNumber, true, out wonItemsList);
        }
        public int doGetRefundTransactions(string sessionHandle, int offset, int limit, out RefundFormDataStruct[] refundFormsList)
        {
            return doGetRefundTransactions(sessionHandle, offset, true, limit, true, out refundFormsList);
        }
        public int doGetRefundsDeals(string sessionId, FilterOptionsType[] filterOptions, string sortOrder, int resultSize, int resultOffset, out RefundsDealsListType[] dealsList, out FiltersListType[] filtersList)
        {
            return doGetRefundsDeals(sessionId, filterOptions, sortOrder, resultSize, true, resultOffset, true, out dealsList, out filtersList);
        }
        public int doGetRefundsList(string sessionId, FilterOptionsType[] filterOptions, int resultSize, int resultOffset, out RefundListType[] refundsList, out FiltersListType[] filtersList)
        {
            return doGetRefundsList(sessionId, filterOptions, resultSize, true, resultOffset, true, out refundsList, out filtersList);
        }
        public SellFormType[] doGetSellFormAttribs(int countryId, string webapiKey, long localVersion, int catId, out long verKey, out string verStr)
        {
            return doGetSellFormAttribs(countryId, webapiKey, localVersion, true, catId, out verKey, out verStr);
        }
        public SellFormType[] doGetSellFormFieldsExt(int countryCode, long localVersion, string webapiKey, out long verKey, out string verStr)
        {
            return doGetSellFormFieldsExt(countryCode, localVersion, true, webapiKey, out verKey, out verStr);
        }
        public SellFormType[] doGetSellFormFieldsExtLimit(int countryCode, long localVersion, string webapiKey, int offset, int packageElement, out long verKey, out string verStr, out int formFieldsCount)
        {
            return doGetSellFormFieldsExtLimit(countryCode, localVersion, true, webapiKey, offset, true, packageElement, true, out verKey, out verStr, out formFieldsCount);
        }
        public ServiceInfoStruct[] doGetServiceInfo(int countryCode, int anCatId, long anItDate, int anItId, string webapiKey)
        {
            return doGetServiceInfo(countryCode, anCatId, anItDate, true, anItId, true, webapiKey);
        }
        public SiteJournal[] doGetSiteJournal(string sessionHandle, long startingPoint, int infoType)
        {
            return doGetSiteJournal(sessionHandle, startingPoint, true, infoType, true);
        }
        public SiteJournalDealsStruct[] doGetSiteJournalDeals(string sessionId, long journalStart)
        {
            return doGetSiteJournalDeals(sessionId, journalStart, true);
        }
        public SiteJournalDealsInfoStruct doGetSiteJournalDealsInfo(string sessionId, long journalStart)
        {
            return doGetSiteJournalDealsInfo(sessionId, journalStart, true);
        }
        public SiteJournalInfo doGetSiteJournalInfo(string sessionHandle, long startingPoint, int infoType)
        {
            return doGetSiteJournalInfo(sessionHandle, startingPoint, true, infoType, true);
        }
        public SpecialAuctionStruct[] doGetSpecialItems(string sessionHandle, int specialType, int specialGroup, int offset, int orderFulfillmentTime)
        {
            return doGetSpecialItems(sessionHandle, specialType, specialGroup, true, offset, true, orderFulfillmentTime, true);
        }
        public UserItemList[] doGetUserItems(int userId, string webapiKey, int countryId, int offset, int limit, out int userItemCount)
        {
            return doGetUserItems(userId, webapiKey, countryId, offset, true, limit, true, out userItemCount);
        }
        public WaitFeedbackStruct[] doGetWaitingFeedbacks(string sessionHandle, int offset, int packageSize)
        {
            return doGetWaitingFeedbacks(sessionHandle, offset, true, packageSize);
        }
        public float doMakeDiscount(string sessionHandle, long dealId, float discountAmount, float discountPercentage)
        {
            return doMakeDiscount(sessionHandle, dealId, discountAmount, true, discountPercentage, true);
        }
        public MyAccountStruct2[] doMyAccount2(string sessionHandle, string accountType, int offset, long[] itemsArray, int limit)
        {
            return doMyAccount2(sessionHandle, accountType, offset, true, itemsArray, limit, true);
        }
        public MyContactList[] doMyContact(string sessionHandle, long[] auctionIdList, int offset, int desc)
        {
            return doMyContact(sessionHandle, auctionIdList, offset, true, desc, true);
        }
        public MyFeedbackListStruct2[] doMyFeedback2(string sessionHandle, string feedbackType, int offset, int desc, long[] itemsArray)
        {
            return doMyFeedback2(sessionHandle, feedbackType, offset, true, desc, true, itemsArray);
        }
        public MyFeedbackListStruct2[] doMyFeedback2Limit(string sessionHandle, string feedbackType, int offset, int desc, long[] itemsArray, int packageElement)
        {
            return doMyFeedback2Limit(sessionHandle, feedbackType, offset, true, desc, true, itemsArray, packageElement, true);
        }
        public long doNewAuctionExt(string sessionHandle, FieldsValue[] fields, int itemTemplateId, int localId, ItemTemplateCreateStruct itemTemplateCreate, out string itemInfo, out int itemIsAllegroStandard)
        {
            return doNewAuctionExt(sessionHandle, fields, itemTemplateId, true, localId, true, itemTemplateCreate, out itemInfo, out itemIsAllegroStandard);
        }
        public StructSellAgain[] doSellSomeAgain(string sessionHandle, long[] sellItemsArray, long sellStartingTime, int sellAuctionDuration, int sellOptions, int[] localIds, out StructSellFailed[] itemsSellFailed, out long[] itemsSellNotFound)
        {
            return doSellSomeAgain(sessionHandle, sellItemsArray, sellStartingTime, true, sellAuctionDuration, sellOptions, true, localIds, out itemsSellFailed, out itemsSellNotFound);
        }
        public StructSellAgain[] doSellSomeAgainInShop(string sessionHandle, long[] sellItemsArray, long sellStartingTime, int sellShopDuration, int sellShopOptions, int sellProlongOptions, long sellShopCategory, int[] localIds, out StructSellFailed[] itemsSellFailed, out long[] itemsSellNotFound)
        {
            return doSellSomeAgainInShop(sessionHandle, sellItemsArray, sellStartingTime, true, sellShopDuration, sellShopOptions, true, sellProlongOptions, true, sellShopCategory, true, localIds, out itemsSellFailed, out itemsSellNotFound);
        }
        public string doSendEmailToUser(string sessionHandle, long mailToUserItemId, ref long mailToUserReceiverId, int mailToUserSubjectId, int mailToUserOption, string mailToUserMessage)
        {
            return doSendEmailToUser(sessionHandle, mailToUserItemId, ref mailToUserReceiverId, mailToUserSubjectId, true, mailToUserOption, true, mailToUserMessage);
        }
        public InfoCatList[] doShowCat(string sessionHandle, int catId, int catItemState, int catItemOption, DurationTimeInfo catItemDurationOption, FieldsValue[] catAttribFields, int catSortOptions, PriceCatInfo catItemsPrice, int catItemsOffset, int catItemsLimit, int catOrderFulfillmentTime, out InfoCatList[] catChildArray, out InfoCatList[] catSisterArray, out int catItemsCount, out int catItemsCountFeatured, out SearchResponseType[] catItemsArray)
        {
            return doShowCat(sessionHandle, catId, catItemState, true, catItemOption, true, catItemDurationOption, catAttribFields, catSortOptions, true, catItemsPrice, catItemsOffset, true, catItemsLimit, true, catOrderFulfillmentTime, true, out catChildArray, out catSisterArray, out catItemsCount, out catItemsCountFeatured, out catItemsArray);
        }
        public ItemInfoExt doShowItemInfoExt(string sessionHandle, long itemId, int getDesc, int getImageUrl, int getAttribs, int getPostageOptions, int getCompanyInfo, int getProductInfo, out ItemCatList[] itemCatPath, out ItemImageList[] itemImgList, out AttribStruct[] itemAttribList, out PostageStruct[] itemPostageOptions, out ItemPaymentOptions itemPaymentOptions, out CompanyInfoStruct itemCompanyInfo, out ProductStruct itemProductInfo)
        {
            return doShowItemInfoExt(sessionHandle, itemId, getDesc, true, getImageUrl, true, getAttribs, true, getPostageOptions, true, getCompanyInfo, true, getProductInfo, true, out itemCatPath, out itemImgList, out itemAttribList, out itemPostageOptions, out itemPaymentOptions, out itemCompanyInfo, out itemProductInfo);
        }
        public int doShowUser(string webapiKey, int countryId, ref long userId, ref string userLogin, out long userCreateDate, out long userLoginDate, out int userRating, out int userIsNewUser, out int userNotActivated, out int userClosed, out int userBlocked, out int userTerminated, out int userHasPage, out int userIsSseller, out int userIsEco, out ShowUserFeedbacks userPositiveFeedback, out ShowUserFeedbacks userNegativeFeedback, out ShowUserFeedbacks userNeutralFeedback, out int userJuniorStatus, out int userHasShop, out int userCompanyIcon, out int userSellRatingCount, out SellRatingAverageStruct[] userSellRatingAverage, out int userIsAllegroStandard, out int userIsB2cSeller)
        {
            bool userIdSpecified = true;
            return doShowUser(webapiKey, countryId, ref userId, ref userIdSpecified, ref userLogin, out userCreateDate, out userLoginDate, out userRating, out userIsNewUser, out userNotActivated, out userClosed, out userBlocked, out userTerminated, out userHasPage, out userIsSseller, out userIsEco, out userPositiveFeedback, out userNegativeFeedback, out userNeutralFeedback, out userJuniorStatus, out userHasShop, out userCompanyIcon, out userSellRatingCount, out userSellRatingAverage, out userIsAllegroStandard, out userIsB2cSeller);
        }
    }
}

