$(() => {
    const app = Sammy('#main', function () {
        this.use('Handlebars', 'hbs')

        //authorizations
        this.get('index.html', (ctx)=>{
            ctx.loggedIn = auth.isAuth()
            ctx.username = sessionStorage.getItem('username')
            ctx.loadPartials({
                header : './templates/common/header.hbs',
                footer : './templates/common/footer.hbs'
            }).then(function () {
                this.partial('./templates/home/home.hbs')
            })
        })
        
        this.get('#/home', (ctx)=>{
            ctx.loggedIn = auth.isAuth()
            ctx.username = sessionStorage.getItem('username')
            ctx.loadPartials({
                header : './templates/common/header.hbs',
                footer : './templates/common/footer.hbs'
            }).then(function () {
                this.partial('./templates/home/home.hbs')
            })
        })

        this.get('#/about', (ctx)=>{
            ctx.loggedIn = auth.isAuth()
            ctx.username = sessionStorage.getItem('username')
            ctx.loadPartials({
                header : './templates/common/header.hbs',
                footer : './templates/common/footer.hbs'
            }).then(function () {
                this.partial('./templates/about/about.hbs')
            })
        })

        this.get('#/login', (ctx)=>{
            ctx.loadPartials({
                header : './templates/common/header.hbs',
                footer : './templates/common/footer.hbs',
                loginForm : './templates/login/loginForm.hbs'
            }).then(function () {
                this.partial('./templates/login/loginPage.hbs')
            })
        })

        this.get('#/register', (ctx)=>{
            ctx.loadPartials({
                header : './templates/common/header.hbs',
                footer : './templates/common/footer.hbs',
                registerForm : './templates/register/registerForm.hbs'
            }).then(function () {
                this.partial('./templates/register/registerPage.hbs')
            })
        })

        this.get('#/logout', (ctx)=>{
            auth.logout().then(function () {
                sessionStorage.clear()
                ctx.redirect('index.html');
            })
        })

        this.post('#/register', (ctx) => {
            let username = ctx.params.username;
            let password = ctx.params.password;
            let repeatPassword = ctx.params.repeatPassword;

            if (password !== repeatPassword) {
                alert('Passwords do not match');
            } else {
                auth.register(username, password)
                    .then((userData) => {
                        auth.saveSession(userData);
                        ctx.redirect('#/home');
                    })
            }
        });

        this.post('#/login', (ctx) => {
            let username = ctx.params.username;
            let password = ctx.params.password;

            auth.login(username, password)
                .then((userData) => {
                    auth.saveSession(userData);
                    ctx.redirect('index.html');
                })
                .catch(console.error);
        });

        //catalog

        this.get('#/catalog', (ctx)=>{
            ctx.username = sessionStorage.getItem('username')
            ctx.loggedIn = auth.isAuth()
            teamsService.loadTeams()
                .then(function (teams) {
                    ctx.hasNoTeam = sessionStorage.getItem('teamId') === null || sessionStorage.getItem('teamId') === 'undefined'
                    ctx.teams = teams
                    ctx.loadPartials({
                        header : './templates/common/header.hbs',
                        footer : './templates/common/footer.hbs',
                        team : './templates/catalog/team.hbs',
                    }).then(function () {
                        this.partial('./templates/catalog/teamCatalog.hbs')
                    })
                })
        })

        //create team
        this.get('#/create', (ctx)=>{
            ctx.username = sessionStorage.getItem('username')
            ctx.loggedIn = auth.isAuth()
            ctx.loadPartials({
                header : './templates/common/header.hbs',
                footer : './templates/common/footer.hbs',
                createForm : './templates/create/createForm.hbs'
            }).then(function () {
                this.partial('./templates/create/createPage.hbs')
            })
        })

        this.post('#/create', (ctx)=>{
            let name = ctx.params.name;
            let comment = ctx.params.comment;

            teamsService.createTeam(name, comment)
                .then(function (teamInfo){
                    teamsService.joinTeam(teamInfo._id)
                        .then(function (userInfo) {
                            auth.saveSession(userInfo)
                            auth.showInfo(`Team ${name} created!`)
                        }).catch(auth.handleError)
                    ctx.redirect('#/catalog');
                })
                .catch(auth.handleError);
        })

        //team details

        this.get('#/catalog/:id', function (ctx) {
            let teamId = ctx.params.id.substr(1);

            teamsService.loadTeamDetails(teamId)
                .then(function (teamInfo) {
                    ctx.loggedIn = auth.isAuth()
                    ctx.username = sessionStorage.getItem('username')
                    ctx.teamId = teamId
                    ctx.name = teamInfo.name
                    ctx.comment = teamInfo.comment
                    ctx.isOnTeam = teamInfo._id === sessionStorage.getItem('teamId')
                    ctx.isAuthor = teamInfo._acl.creator === sessionStorage.getItem('userId')
                    ctx.loadPartials({
                        header : './templates/common/header.hbs',
                        footer : './templates/common/footer.hbs',
                        teamControls : './templates/catalog/teamControls.hbs'
                    }).then(function() {
                        this.partial('./templates/catalog/details.hbs')
                    })
                })
        })

        this.get('#/join/:id', function (ctx) {
            let teamId = ctx.params.id.substr(1);

            teamsService.joinTeam(teamId)
                .then(function (userInfo) {
                    auth.saveSession(userInfo)
                    auth.showInfo('Joined in a team!')
                    ctx.redirect('#/catalog')
                }).catch(auth.handleError)
        })

        this.get('#/leave', function (ctx){
            teamsService.leaveTeam()
                .then(function (userInfo) {
                    auth.saveSession(userInfo)
                    auth.showInfo('Left the team!')
                    ctx.redirect('#/catalog')
                }).catch(auth.handleError)
        })

        this.get('#/edit/:id', function (ctx) {
            let teamId = ctx.params.id.substr(1);
            teamsService.loadTeamDetails(teamId)
                .then(function (teamInfo) {
                    ctx.teamId = teamId
                    ctx.name = teamInfo.name
                    ctx.comment = teamInfo.comment
                    ctx.loadPartials({
                        header : './templates/common/header.hbs',
                        footer : './templates/common/footer.hbs',
                        editForm : './templates/edit/editForm.hbs'
                    }).then(function () {
                        this.partial('./templates/edit/editPage.hbs')
                    })
                })
        })

        this.post('#/edit/:id', (ctx)=>{
            let teamId = ctx.params.id.substr(1);
            let name = ctx.params.name;
            let comment = ctx.params.comment;

            teamsService.edit(teamId, name, comment)
                .then(function (){
                    auth.showInfo(`Team ${name} edited!`)
                    ctx.redirect('#/catalog');
                })
                .catch(auth.handleError);
        })
    });

    app.run();
});