# coding: utf-8

"""
    Coinsecure Api Documentation

    To generate an API key, please visit <a href='https://coinsecure.in/api' target='_new' class='homeapi'>https://coinsecure.in/api</a>.<br>Guidelines for use can be accessed at <a href='https://api.coinsecure.in/v1/guidelines'>https://api.coinsecure.in/v1/guidelines</a>.<br>Programming Language Libraries for use can be accessed at <a href='https://api.coinsecure.in/v1/code-libraries'>https://api.coinsecure.in/v1/code-libraries</a>.

    OpenAPI spec version: beta
    
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

import os
import sys
import unittest

import swagger_client
from swagger_client.rest import ApiException
from swagger_client.apis.exchange_bank_coin_data_api import ExchangeBankCoinDataApi


class TestExchangeBankCoinDataApi(unittest.TestCase):
    """ ExchangeBankCoinDataApi unit test stubs """

    def setUp(self):
        self.api = swagger_client.apis.exchange_bank_coin_data_api.ExchangeBankCoinDataApi()

    def tearDown(self):
        pass

    def test_v1userexchangebankcoinaddresses(self):
        """
        Test case for v1userexchangebankcoinaddresses

        Exchange Coin Addresses
        """
        pass

    def test_v1userexchangebankcoinbalanceavailable(self):
        """
        Test case for v1userexchangebankcoinbalanceavailable

        Available Exchange Coin Balance
        """
        pass

    def test_v1userexchangebankcoinbalancepending(self):
        """
        Test case for v1userexchangebankcoinbalancepending

        In Trade Coin Balance
        """
        pass

    def test_v1userexchangebankcoinbalancetotal(self):
        """
        Test case for v1userexchangebankcoinbalancetotal

        Total Exchange Coin Balance
        """
        pass

    def test_v1userexchangebankcoindepositcancelled(self):
        """
        Test case for v1userexchangebankcoindepositcancelled

        Cancelled Exchange Coin Deposits
        """
        pass

    def test_v1userexchangebankcoindepositunverified(self):
        """
        Test case for v1userexchangebankcoindepositunverified

        Unverified Exchange Coin Deposits
        """
        pass

    def test_v1userexchangebankcoindepositverified(self):
        """
        Test case for v1userexchangebankcoindepositverified

        Verified Exchange Coin Deposits
        """
        pass

    def test_v1userexchangebankcoinwithdrawcancelled(self):
        """
        Test case for v1userexchangebankcoinwithdrawcancelled

        Cancelled Exchange Coin Withdrawals
        """
        pass

    def test_v1userexchangebankcoinwithdrawcompleted(self):
        """
        Test case for v1userexchangebankcoinwithdrawcompleted

        Completed Exchange Coin Withdrawals
        """
        pass

    def test_v1userexchangebankcoinwithdrawunverified(self):
        """
        Test case for v1userexchangebankcoinwithdrawunverified

        Unverified Exchange Coin Withdrawals
        """
        pass

    def test_v1userexchangebankcoinwithdrawverified(self):
        """
        Test case for v1userexchangebankcoinwithdrawverified

        Verified Exchange Coin Withdrawals
        """
        pass


if __name__ == '__main__':
    unittest.main()
