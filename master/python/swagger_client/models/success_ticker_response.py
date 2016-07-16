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

from pprint import pformat
from six import iteritems
import re


class SuccessTickerResponse(object):
    """
    NOTE: This class is auto generated by the swagger code generator program.
    Do not edit the class manually.
    """
    def __init__(self):
        """
        SuccessTickerResponse - a model defined in Swagger

        :param dict swaggerTypes: The key is attribute name
                                  and the value is attribute type.
        :param dict attributeMap: The key is attribute name
                                  and the value is json key in definition.
        """
        self.swagger_types = {
            'last_price': 'int',
            'timestamp': 'int',
            'bid': 'int',
            'ask': 'int',
            'fiat_volume': 'int',
            'coin_volume': 'int',
            'open': 'int',
            'high': 'int',
            'low': 'int'
        }

        self.attribute_map = {
            'last_price': 'lastPrice',
            'timestamp': 'timestamp',
            'bid': 'bid',
            'ask': 'ask',
            'fiat_volume': 'fiatVolume',
            'coin_volume': 'coinVolume',
            'open': 'open',
            'high': 'high',
            'low': 'low'
        }

        self._last_price = None
        self._timestamp = None
        self._bid = None
        self._ask = None
        self._fiat_volume = None
        self._coin_volume = None
        self._open = None
        self._high = None
        self._low = None

    @property
    def last_price(self):
        """
        Gets the last_price of this SuccessTickerResponse.


        :return: The last_price of this SuccessTickerResponse.
        :rtype: int
        """
        return self._last_price

    @last_price.setter
    def last_price(self, last_price):
        """
        Sets the last_price of this SuccessTickerResponse.


        :param last_price: The last_price of this SuccessTickerResponse.
        :type: int
        """
        
        self._last_price = last_price

    @property
    def timestamp(self):
        """
        Gets the timestamp of this SuccessTickerResponse.


        :return: The timestamp of this SuccessTickerResponse.
        :rtype: int
        """
        return self._timestamp

    @timestamp.setter
    def timestamp(self, timestamp):
        """
        Sets the timestamp of this SuccessTickerResponse.


        :param timestamp: The timestamp of this SuccessTickerResponse.
        :type: int
        """
        
        self._timestamp = timestamp

    @property
    def bid(self):
        """
        Gets the bid of this SuccessTickerResponse.


        :return: The bid of this SuccessTickerResponse.
        :rtype: int
        """
        return self._bid

    @bid.setter
    def bid(self, bid):
        """
        Sets the bid of this SuccessTickerResponse.


        :param bid: The bid of this SuccessTickerResponse.
        :type: int
        """
        
        self._bid = bid

    @property
    def ask(self):
        """
        Gets the ask of this SuccessTickerResponse.


        :return: The ask of this SuccessTickerResponse.
        :rtype: int
        """
        return self._ask

    @ask.setter
    def ask(self, ask):
        """
        Sets the ask of this SuccessTickerResponse.


        :param ask: The ask of this SuccessTickerResponse.
        :type: int
        """
        
        self._ask = ask

    @property
    def fiat_volume(self):
        """
        Gets the fiat_volume of this SuccessTickerResponse.


        :return: The fiat_volume of this SuccessTickerResponse.
        :rtype: int
        """
        return self._fiat_volume

    @fiat_volume.setter
    def fiat_volume(self, fiat_volume):
        """
        Sets the fiat_volume of this SuccessTickerResponse.


        :param fiat_volume: The fiat_volume of this SuccessTickerResponse.
        :type: int
        """
        
        self._fiat_volume = fiat_volume

    @property
    def coin_volume(self):
        """
        Gets the coin_volume of this SuccessTickerResponse.


        :return: The coin_volume of this SuccessTickerResponse.
        :rtype: int
        """
        return self._coin_volume

    @coin_volume.setter
    def coin_volume(self, coin_volume):
        """
        Sets the coin_volume of this SuccessTickerResponse.


        :param coin_volume: The coin_volume of this SuccessTickerResponse.
        :type: int
        """
        
        self._coin_volume = coin_volume

    @property
    def open(self):
        """
        Gets the open of this SuccessTickerResponse.


        :return: The open of this SuccessTickerResponse.
        :rtype: int
        """
        return self._open

    @open.setter
    def open(self, open):
        """
        Sets the open of this SuccessTickerResponse.


        :param open: The open of this SuccessTickerResponse.
        :type: int
        """
        
        self._open = open

    @property
    def high(self):
        """
        Gets the high of this SuccessTickerResponse.


        :return: The high of this SuccessTickerResponse.
        :rtype: int
        """
        return self._high

    @high.setter
    def high(self, high):
        """
        Sets the high of this SuccessTickerResponse.


        :param high: The high of this SuccessTickerResponse.
        :type: int
        """
        
        self._high = high

    @property
    def low(self):
        """
        Gets the low of this SuccessTickerResponse.


        :return: The low of this SuccessTickerResponse.
        :rtype: int
        """
        return self._low

    @low.setter
    def low(self, low):
        """
        Sets the low of this SuccessTickerResponse.


        :param low: The low of this SuccessTickerResponse.
        :type: int
        """
        
        self._low = low

    def to_dict(self):
        """
        Returns the model properties as a dict
        """
        result = {}

        for attr, _ in iteritems(self.swagger_types):
            value = getattr(self, attr)
            if isinstance(value, list):
                result[attr] = list(map(
                    lambda x: x.to_dict() if hasattr(x, "to_dict") else x,
                    value
                ))
            elif hasattr(value, "to_dict"):
                result[attr] = value.to_dict()
            elif isinstance(value, dict):
                result[attr] = dict(map(
                    lambda item: (item[0], item[1].to_dict())
                    if hasattr(item[1], "to_dict") else item,
                    value.items()
                ))
            else:
                result[attr] = value

        return result

    def to_str(self):
        """
        Returns the string representation of the model
        """
        return pformat(self.to_dict())

    def __repr__(self):
        """
        For `print` and `pprint`
        """
        return self.to_str()

    def __eq__(self, other):
        """
        Returns true if both objects are equal
        """
        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """
        Returns true if both objects are not equal
        """
        return not self == other
