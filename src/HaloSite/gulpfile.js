var gulp = require("gulp"),
    ts = require("gulp-typescript"),
    merge = require("merge"),
    fs = require("fs"),
	wiredep = require("wiredep").stream,
	gulpInject = require("gulp-inject"),
	mainBowerFiles = require("main-bower-files"),
	rimraf = require("gulp-rimraf"),
	project = require("./project.json");

var paths = {
	npm: "./node_modules/",
	lib: "./" + project.webroot + "/lib/",
	appDir: "./App/",
	appSource: "./App/**/*.ts",
	appOutput: "./" + project.webroot + "/App/",
	tsDef: "./typings/"
};

var tsProject = ts.createProject({
	declarationFiles: true,
	noExternalResolve: false,
	module: "AMD",
	removeComments: true
});

gulp.task("ts-compile", function () {
	var tsResult = gulp.src(paths.appSource)
                    .pipe(ts(tsProject));
	return merge([
        tsResult.dts.pipe(gulp.dest(paths.tsDef)),
        tsResult.js.pipe(gulp.dest(paths.appOutput))
	]);
});

gulp.task("inject", ["copyMainFiles", "ts-compile"], function () {
	var indexHtml = gulp.src("./App/index.html");
	var jsFiles = gulp.src([paths.appOutput + "/**/*.js"], { read: false });

	indexHtml
		.pipe(wiredep())
		.pipe(gulp.dest(paths.appOutput));
	return indexHtml
		.pipe(gulpInject(jsFiles, { relative: true }))
		.pipe(gulp.dest(paths.appOutput));
});

gulp.task("build", ["copyMainFiles", "ts-compile", "inject"]);

gulp.task("clean", function() {
	return gulp.src([paths.appOutput, "!" + project.webroot + "/web.config", project.webroot + "/bower_components"], { read: false }).pipe(rimraf());
});

gulp.task("copyMainFiles", function () {
	return gulp.src(mainBowerFiles(), { base: "bower_components" })
                .pipe(gulp.dest(project.webroot + "/bower_components"));
});

gulp.task("watch", ["ts-compile"], function () {
	gulp.watch(paths.tsDef, ["ts-compile"]);
});