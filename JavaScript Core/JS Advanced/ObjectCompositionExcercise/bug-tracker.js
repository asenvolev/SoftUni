function bugTracker() {
    return {
        reports : [],
        selector : undefined, 
        counter : 0,      
        report : function (author, description, reproducible, severity) {
            this.reports[this.counter] = {
                ID : this.counter,
                author,
                description,
                reproducible,
                severity,
                status : 'Open'
            }
            this.counter++
            if(this.selector){
                this.draw();
            }
        },
        setStatus : function (id, newStatus) {
            let reportToChange = this.reports.filter(x=>x.ID===id)[0]
            reportToChange.status = newStatus
            if(this.selector){
                this.draw();
            }
        },
        remove : function (id) {
            this.reports = this.reports.filter(x=>x.ID!==id)
            if(this.selector){
                this.draw();
            }
        },
        sort : function (method) {
            switch (method) {
                case 'ID':
                    this.reports = this.reports.sort((a,b)=>a.ID - b.ID)
                    break;
                case 'author':
                    this.reports = this.reports.sort((a,b)=>a.author.localeCompare(b.author))
                    break;
                case 'author':
                    this.reports = this.reports.sort((a,b)=>a.severity- b.severity)
                    break;
                default:
                    this.reports = this.reports.sort((a,b)=>a.ID - b.ID)
                    break;
            }
        },
        output : function (selec) {
            this.selector = selec
        },
        draw : function () {
            $(this.selector).html("");
            for(let bug of this.reports){
                $(this.selector).append($('<div>').attr('id', "report_" + bug.ID).addClass('report').append($('<div>').addClass('body').append($('<p>').text(bug.description))).append($('<div>').addClass('title').append($('<span>').addClass('author').text('Submitted by: ' + bug.author)).append($('<span>').addClass('status').text(bug.status + " | " + bug.severity))));
            }
        }
    }
}