﻿/*jslint vars: true*/
/*global describe, it, expect, waits, waitsFor, runs, afterEach, spyOn, $*/

describe('Blog: Authors', function () {
    'use strict';

    it('02000: Should get a list of authors', function () {
        var url = '/bcms-api/authors/',
            result,
            ready = false;

        var data = {
            filter: {
                where: [{ field: 'Name', operation: 'StartsWith', value: '_0000_' }]
            },
            order: {
                by: [{ field: 'Name' }]
            },
            take: 2,
            skip: 1,
            includeUnpublished: true
        };

        runs(function () {
            api.get(url, data, function (json) {
                result = json;
                ready = true;
            });
        });

        waitsFor(function () {
            return ready;
        }, 'The ' + url + ' timeout.');

        runs(function () {
            expect(result).not.toBeNull();
            expect(result.data).not.toBeNull();
            expect(result.data.totalCount).toBe(4);
            expect(result.data.items.length).toBe(2);

            api.expectBasePropertiesAreNotNull(result.data.items[0]);
            api.expectBasePropertiesAreNotNull(result.data.items[1]);
            
            expect(result.data.items[0].name).toBe('_0000_Author_2');
            expect(result.data.items[0].imageId).not.toBeNull();
            expect(result.data.items[0].imageUrl).not.toBeNull();
            expect(result.data.items[0].imageThumbnailUrl).not.toBeNull();
            expect(result.data.items[0].imageCaption).toBe('Image caption for _0000_Author_2');
            
            expect(result.data.items[1].name).toBe('_0000_Author_3');
            expect(result.data.items[1].imageId).toBeNull();
            expect(result.data.items[1].imageUrl).toBeNull();
            expect(result.data.items[1].imageThumbnailUrl).toBeNull();
            expect(result.data.items[1].imageCaption).toBeNull();
        });
    });
    
    it('02001: Should get an author by id', function () {
        var url = '/bcms-api/authors/b82a9428b40047c498a9a20500b7a276',
            result,
            ready = false;

        runs(function () {
            api.get(url, null, function (json) {
                result = json;
                ready = true;
            });
        });

        waitsFor(function () {
            return ready;
        }, 'The ' + url + ' timeout.');

        runs(function () {
            expect(result).not.toBeNull();

            var author = result.data;
            expect(author).not.toBeNull();
            api.expectBasePropertiesAreNotNull(author);
            
            expect(author.name).toBe('_0000_Author_2');
            expect(author.imageId).not.toBeNull();
            expect(author.imageUrl).not.toBeNull();
            expect(author.imageThumbnailUrl).not.toBeNull();
            expect(author.imageCaption).toBe('Image caption for _0000_Author_2');
        });
    });
    
    it('02002: Should get a list with one author, filtered by all available columns', function () {
        var url = '/bcms-api/authors/',
            result,
            ready = false;

        var data = {
            filter: {
                where: [
                    { field: 'Id', value: '200f5ee252af47abb5bea20601210dd3' },
                    { field: 'CreatedOn', value: '2013-07-25 17:32:24.000' },
                    { field: 'CreatedBy', value: 'Better CMS test user' },
                    { field: 'LastModifiedOn', value: '2013-07-25 17:32:59.000' },
                    { field: 'LastModifiedBy', value: 'Better CMS test user' },
                    { field: 'Version', value: '2' },
                    { field: 'Name', value: '02002' },
                    { field: 'ImageId', value: 'a19a6e5d7e4948a5b5e0a206012117bd' },
                    { field: 'ImageUrl', value: 'http://bettercms.sandbox.mvc4.local/uploads/image/b244cadb494d4121b896f21ac93483ef/1_1.jpg' },
                    { field: 'ImageThumbnailUrl', value: 'http://bettercms.sandbox.mvc4.local/uploads/image/b244cadb494d4121b896f21ac93483ef/t_1_1.png' },
                    { field: 'ImageCaption', value: 'Image Caption' }
                ]
            }
        };

        runs(function () {
            api.get(url, data, function (json) {
                result = json;
                ready = true;
            });
        });

        waitsFor(function () {
            return ready;
        }, 'The ' + url + ' timeout.');

        runs(function () {
            expect(result).not.toBeNull();
            expect(result.data).not.toBeNull();
            expect(result.data.totalCount).toBe(1);
            expect(result.data.items.length).toBe(1);

            expect(result.data.items[0].id).toBe('200f5ee252af47abb5bea20601210dd3');

            // Check if model properties count didn't changed. If so - update filter current test filter and another tests.
            expect(data.filter.where.length).toBe(api.getCountOfProperties(result.data.items[0]));
        });
    });
});