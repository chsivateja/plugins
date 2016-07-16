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

import os
import sys
import unittest

import swagger_client
from swagger_client.rest import ApiException
from swagger_client.apis.exchange_trade_data_api import ExchangeTradeDataApi


class TestExchangeTradeDataApi(unittest.TestCase):
    """ ExchangeTradeDataApi unit test stubs """

    def setUp(self):
        self.api = swagger_client.apis.exchange_trade_data_api.ExchangeTradeDataApi()

    def tearDown(self):
        pass

    def test_v1exchangeasklow(self):
        """
        Test case for v1exchangeasklow

        Lowest Ask
        """
        pass

    def test_v1exchangeaskorders(self):
        """
        Test case for v1exchangeaskorders

        All Sell Orders
        """
        pass

    def test_v1exchangebidhigh(self):
        """
        Test case for v1exchangebidhigh

        Returns the Highest Bid in the Order Book
        """
        pass

    def test_v1exchangebidorders(self):
        """
        Test case for v1exchangebidorders

        All Buy Orders
        """
        pass

    def test_v1exchangelast_trade(self):
        """
        Test case for v1exchangelast_trade

        Last Trade
        """
        pass

    def test_v1exchangemax24_hr(self):
        """
        Test case for v1exchangemax24_hr

        Max 24 Hour Rate
        """
        pass

    def test_v1exchangemin24_hr(self):
        """
        Test case for v1exchangemin24_hr

        Min 24 Hour Rate
        """
        pass

    def test_v1exchangeticker(self):
        """
        Test case for v1exchangeticker

        Exchange Ticker
        """
        pass

    def test_v1userexchangeaskcancelled(self):
        """
        Test case for v1userexchangeaskcancelled

        Cancelled User Sell Orders
        """
        pass

    def test_v1userexchangeaskcompleted(self):
        """
        Test case for v1userexchangeaskcompleted

        Completed User Sell Orders
        """
        pass

    def test_v1userexchangeaskpending(self):
        """
        Test case for v1userexchangeaskpending

        Pending User Sell Orders
        """
        pass

    def test_v1userexchangebidcancelled(self):
        """
        Test case for v1userexchangebidcancelled

        Cancelled User Buy Orders
        """
        pass

    def test_v1userexchangebidcompleted(self):
        """
        Test case for v1userexchangebidcompleted

        Completed User Buy Orders
        """
        pass

    def test_v1userexchangebidpending(self):
        """
        Test case for v1userexchangebidpending

        Pending User Buy Orders
        """
        pass


if __name__ == '__main__':
    unittest.main()