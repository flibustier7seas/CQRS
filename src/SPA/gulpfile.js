/// <binding ProjectOpened='default' />
'use strict';

var browserify = require('browserify');
var watchify = require('watchify');
var gulp = require('gulp');
var source = require('vinyl-source-stream');

var sourceFile = './js/app.js';
var destFile = 'index.js';
var destFolder = './';

var browserifyBundler = browserify(sourceFile, {
    cache: {},
    packageCache: {},
    fullPaths: true,
    debug: true
});

gulp.task('browserify', function () {
    return browserifyBundler
        .bundle()
        .pipe(source(destFile))
        .pipe(gulp.dest(destFolder));
});

gulp.task('watch', function () {
    var bundler = watchify(browserifyBundler);

    bundler.on('update', rebundle);

    function rebundle() {
        return bundler.bundle()
          .pipe(source(destFile))
          .pipe(gulp.dest(destFolder));
    }

    return rebundle();
});

gulp.task('default', ['browserify', 'watch']);