import React, { Component } from 'react';
import Terms from './TermsOfServicePage/Terms';
import Footer from './LandingPage/Footer';

class TermsOfServicePage extends Component {
    render() {
        return (
            <div>
                <main className="main">
                    <Terms />
                </main>
                <Footer />
            </div>
        );
    }
}

export default TermsOfServicePage;
