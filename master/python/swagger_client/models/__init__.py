# coding: utf-8

"""
    Coinsecure Api Documentation

    To generate an API key, please visit <a href='https://coinsecure.in/api' target='_new' class='homeapi'>https://coinsecure.in/api</a>.<br>Guidelines for use can be accessed at <a href='https://api.coinsecure.in/v1/guidelines'>https://api.coinsecure.in/v1/guidelines</a>.<br>Programming Language Libraries for use can be accessed at <a href='https://api.coinsecure.in/v1/code-libraries'>https://api.coinsecure.in/v1/code-libraries</a>.

    OpenAPI spec version: 1.0b
    
    Generated by: https://github.com/swagger-api/swagger-codegen.git
    
    Licensed under the Apache License, Version 2.0 (the "License");
    you may not use this file except in compliance with the License.
    You may obtain a copy of the License at
    
        http://www.apache.org/licenses/LICENSE-2.0
    
    Unless required by applicable law or agreed to in writing, software
    distributed under the License is distributed on an "AS IS" BASIS,
    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    See the License for the specific language governing permissions and
    limitations under the License.
"""

from __future__ import absolute_import

# import models into model package
from .address import Address
from .all_ref_data import AllRefData
from .all_ref_data_response import AllRefDataResponse
from .ask_id import AskID
from .bank_summary_data import BankSummaryData
from .bank_summary_data_response import BankSummaryDataResponse
from .bid_id import BidID
from .change_password import ChangePassword
from .code import Code
from .code_country_mobile import CodeCountryMobile
from .coin_dep_data import CoinDepData
from .coin_dep_data_response import CoinDepDataResponse
from .confirm_data import ConfirmData
from .confirm_data_response import ConfirmDataResponse
from .deposit_id import DepositID
from .double_data import DoubleData
from .double_data_response import DoubleDataResponse
from .email import Email
from .fail_result import FailResult
from .fiat_bank_data import FiatBankData
from .fiat_bank_data_response import FiatBankDataResponse
from .fiat_dep_data import FiatDepData
from .fiat_dep_data_response import FiatDepDataResponse
from .fiat_with_data import FiatWithData
from .fiat_with_data_response import FiatWithDataResponse
from .js_value import JsValue
from .kyc_data import KYCData
from .kyc_data_response import KYCDataResponse
from .last_trade_data import LastTradeData
from .last_trade_data_response import LastTradeDataResponse
from .login_form_new import LoginFormNew
from .login_id import LoginId
from .max_vol import MaxVol
from .method_country_mobile import MethodCountryMobile
from .min_fiat import MinFiat
from .netki_name import NetkiName
from .netki_name_address import NetkiNameAddress
from .new_address import NewAddress
from .new_bank_form import NewBankForm
from .new_fiat_bank_deposit import NewFiatBankDeposit
from .new_wallet import NewWallet
from .number_otp import NumberOtp
from .order_data import OrderData
from .order_data_response import OrderDataResponse
from .rate_data import RateData
from .rate_data_response import RateDataResponse
from .rate_diff_data import RateDiffData
from .rate_diff_data_response import RateDiffDataResponse
from .rate_vol_data import RateVolData
from .rate_vol_data_response import RateVolDataResponse
from .reset_password import ResetPassword
from .send_coin import SendCoin
from .send_coin_wallet import SendCoinWallet
from .send_exchange import SendExchange
from .signup_form import SignupForm
from .standard_initiate_login_result_data import StandardInitiateLoginResultData
from .standard_login_result_data import StandardLoginResultData
from .standard_ticker_result_data import StandardTickerResultData
from .succ_coin_ref_data import SuccCoinRefData
from .succ_coin_ref_data_response import SuccCoinRefDataResponse
from .succ_ref_data import SuccRefData
from .succ_ref_data_response import SuccRefDataResponse
from .success_initiate_login_response import SuccessInitiateLoginResponse
from .success_login_response import SuccessLoginResponse
from .success_result import SuccessResult
from .success_result_list import SuccessResultList
from .success_ticker_response import SuccessTickerResponse
from .time_data import TimeData
from .time_data_coin import TimeDataCoin
from .time_kyc_data import TimeKYCData
from .trade_address_data import TradeAddressData
from .trade_address_data_response import TradeAddressDataResponse
from .trade_coin_withdraw_data import TradeCoinWithdrawData
from .trade_coin_withdraw_data_response import TradeCoinWithdrawDataResponse
from .trade_summary_data import TradeSummaryData
from .trade_summary_data_response import TradeSummaryDataResponse
from .user_summary_data import UserSummaryData
from .user_summary_data_response import UserSummaryDataResponse
from .valid_address_search_data import ValidAddressSearchData
from .valid_address_search_data_response import ValidAddressSearchDataResponse
from .vol_data import VolData
from .vol_data_response import VolDataResponse
from .wallet_address_data import WalletAddressData
from .wallet_address_data_response import WalletAddressDataResponse
from .wallet_coin_withdraw_data import WalletCoinWithdrawData
from .wallet_coin_withdraw_data_response import WalletCoinWithdrawDataResponse
from .wallet_summary_data import WalletSummaryData
from .wallet_summary_data_response import WalletSummaryDataResponse
from .wallets_data import WalletsData
from .wallets_data_response import WalletsDataResponse
from .withdraw_fiat import WithdrawFiat
from .withdraw_id import WithdrawID